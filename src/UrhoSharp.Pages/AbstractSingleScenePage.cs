using System.Collections.Generic;
using Urho;
using Urho.Audio;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Pages
{
    public abstract class AbstractSingleScenePage : AbstractScenePage
    {
        private readonly UrhoRef<Camera> _camera = new UrhoRef<Camera>();

        private readonly UrhoRef<SoundSource> _musicSoundSource = new UrhoRef<SoundSource>();
        private readonly UrhoRef<RenderPath> _renderPath = new UrhoRef<RenderPath>();
        private readonly UrhoRef<Scene> _scene = new UrhoRef<Scene>();

        private readonly UrhoRef<Sound> _currentMusicTrack = new UrhoRef<Sound>();
        private float _musicGain = 0.5f;

        public Scene Scene
        {
            get => _scene.Value;
            set
            {
                if (_scene.Value != value)
                {
                    _scene.Value = value;
                    InvalidateViewports();
                    OnSceneChanged();
                }
            }
        }

        public Camera Camera
        {
            get => _camera.Value;
            set
            {
                if (_camera.Value != value)
                {
                    _camera.Value = value;
                    InvalidateViewports();
                    OnCameraChanged();
                }
            }
        }

        public RenderPath RenderPath
        {
            get => _renderPath.Value;
            set
            {
                if (_renderPath.Value != value)
                {
                    _renderPath.Value = value;
                    InvalidateViewports();
                }
            }
        }

        public float MusicGain
        {
            get => _musicGain;
            set
            {
                if (_musicGain != value)
                {
                    _musicGain = value;
                    if (_musicSoundSource.HasValue)
                        _musicSoundSource.Value.Gain = _musicGain;
                }
            }
        }

        public SoundSource MusicSoundSource
        {
            get
            {
                if (_musicSoundSource.HasValue)
                    return _musicSoundSource.Value;
                if (!_scene.HasValue)
                    return null;
                MusicSoundSource = _scene.Value.GetOrCreateComponent<SoundSource>();
                return _musicSoundSource.Value;
            }
            set
            {
                if (_musicSoundSource.HasValue)
                    _musicSoundSource.Value.Stop();
                _musicSoundSource.Value = value;
                if (_musicSoundSource.HasValue)
                {
                    _musicSoundSource.Value.SetSoundType(SoundType.Music.ToString());
                    _musicSoundSource.Value.Gain = _musicGain;
                    if (_currentMusicTrack.HasValue) _musicSoundSource.Value.Play(_currentMusicTrack.Value);
                }
            }
        }

        protected virtual void OnSceneChanged()
        {
        }

        protected virtual void OnCameraChanged()
        {
        }

        public override async void OnResumed()
        {
            base.OnResumed();

            var track = _currentMusicTrack.Value;
            if (track != null) await _scheduler.RunAsync(() => { MusicSoundSource?.Play(track); });
        }

        public override void OnPaused()
        {
            base.OnPaused();

            if (_musicSoundSource.HasValue)
                _musicSoundSource.Value.Stop();
        }

        protected void PlayMusic(Sound track)
        {
            _currentMusicTrack.Value = track;
            if (State == ScenePageState.Active) MusicSoundSource?.Play(track);
        }

        protected void CreateSimpleScene(float radius = 100.0f)
        {
            CreateSimpleScene(new BoundingBox(new Vector3(-radius, -radius, -radius),
                new Vector3(radius, radius, radius)));
        }

        protected void CreateSimpleScene(BoundingBox bbox)
        {
            Scene = new Scene();
            var octree = Scene.CreateComponent<Octree>();
            octree.SetSize(bbox, 10);
            var z = Scene.CreateComponent<Zone>();
            z.SetBoundingBox(bbox);
            var cameraNode = Scene.CreateChild();
            Camera = cameraNode.CreateComponent<Camera>();
        }

        public override IList<Viewport> GetViewports()
        {
            if (_scene == null || _camera == null)
                return new Viewport[0];
            return new[] {new Viewport(_scene.Value, _camera.Value, _renderPath.Value)};
        }
    }
}