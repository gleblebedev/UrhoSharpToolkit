using System;
using System.Xml.Linq;
using Urho;
using Text3D = Urho.Gui.Text3D;

using Urho.Gui;

namespace UrhoSharp.Prefabs
{
    public class Text3DPrefab: AbstractComponentPrefab<Text3D>, IPrefab
    {
        private static  float FontSizeDefaultValue = 12f;
        private static  Material MaterialDefaultValue = null;
        private static  String TextDefaultValue = "";
        private static  HorizontalAlignment HorizontalAlignmentDefaultValue = HorizontalAlignment.Left;
        private static  VerticalAlignment VerticalAlignmentDefaultValue = VerticalAlignment.Top;
        private static  HorizontalAlignment TextAlignmentDefaultValue = HorizontalAlignment.Left;
        private static  float RowSpacingDefaultValue = 1f;
        private static  bool WordwrapDefaultValue = false;
        private static  TextEffect TextEffectDefaultValue = TextEffect.None;
        private static  IntVector2 EffectShadowOffsetDefaultValue = new IntVector2(1, 1);
        private static  int EffectStrokeThicknessDefaultValue = 1;
        private static  bool EffectRoundStrokeDefaultValue = false;
        private static  Color EffectColorDefaultValue = new Color(0f, 0f, 0f, 1f);
        private static  float EffectDepthBiasDefaultValue = 0.1f;
        private static  int WidthDefaultValue = 0;
        private static  float OpacityDefaultValue = 1f;
        private static  bool FixedScreenSizeDefaultValue = false;
        private static  FaceCameraMode FaceCameraModeDefaultValue = FaceCameraMode.None;
        private static  float DrawDistanceDefaultValue = 0f;
        private static  float ShadowDistanceDefaultValue = 0f;
        private static  float LodBiasDefaultValue = 1f;
        private static  uint ViewMaskDefaultValue = 4294967295;
        private static  uint LightMaskDefaultValue = 4294967295;
        private static  uint ShadowMaskDefaultValue = 4294967295;
        private static  uint ZoneMaskDefaultValue = 4294967295;
        private static  uint MaxLightsDefaultValue = 0;
        private static  bool CastShadowsDefaultValue = false;
        private static  bool OccluderDefaultValue = false;
        private static  bool OccludeeDefaultValue = true;
        private static  float SortValueDefaultValue = 0f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _fontSize;
        private Material _material;
        private String _text;
        private HorizontalAlignment _horizontalAlignment;
        private VerticalAlignment _verticalAlignment;
        private HorizontalAlignment _textAlignment;
        private float _rowSpacing;
        private bool _wordwrap;
        private TextEffect _textEffect;
        private IntVector2 _effectShadowOffset;
        private int _effectStrokeThickness;
        private bool _effectRoundStroke;
        private Color _effectColor;
        private float _effectDepthBias;
        private int _width;
        private float _opacity;
        private bool _fixedScreenSize;
        private FaceCameraMode _faceCameraMode;
        private float _drawDistance;
        private float _shadowDistance;
        private float _lodBias;
        private uint _viewMask;
        private uint _lightMask;
        private uint _shadowMask;
        private uint _zoneMask;
        private uint _maxLights;
        private bool _castShadows;
        private bool _occluder;
        private bool _occludee;
        private float _sortValue;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public Text3DPrefab()
        {
            _fontSize = FontSizeDefaultValue;
            _material = MaterialDefaultValue;
            _text = TextDefaultValue;
            _horizontalAlignment = HorizontalAlignmentDefaultValue;
            _verticalAlignment = VerticalAlignmentDefaultValue;
            _textAlignment = TextAlignmentDefaultValue;
            _rowSpacing = RowSpacingDefaultValue;
            _wordwrap = WordwrapDefaultValue;
            _textEffect = TextEffectDefaultValue;
            _effectShadowOffset = EffectShadowOffsetDefaultValue;
            _effectStrokeThickness = EffectStrokeThicknessDefaultValue;
            _effectRoundStroke = EffectRoundStrokeDefaultValue;
            _effectColor = EffectColorDefaultValue;
            _effectDepthBias = EffectDepthBiasDefaultValue;
            _width = WidthDefaultValue;
            _opacity = OpacityDefaultValue;
            _fixedScreenSize = FixedScreenSizeDefaultValue;
            _faceCameraMode = FaceCameraModeDefaultValue;
            _drawDistance = DrawDistanceDefaultValue;
            _shadowDistance = ShadowDistanceDefaultValue;
            _lodBias = LodBiasDefaultValue;
            _viewMask = ViewMaskDefaultValue;
            _lightMask = LightMaskDefaultValue;
            _shadowMask = ShadowMaskDefaultValue;
            _zoneMask = ZoneMaskDefaultValue;
            _maxLights = MaxLightsDefaultValue;
            _castShadows = CastShadowsDefaultValue;
            _occluder = OccluderDefaultValue;
            _occludee = OccludeeDefaultValue;
            _sortValue = SortValueDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public Text3DPrefab(Text3D val)
        {
            _fontSize = val.FontSize;
            _material = val.Material;
            _text = val.Text;
            _horizontalAlignment = val.HorizontalAlignment;
            _verticalAlignment = val.VerticalAlignment;
            _textAlignment = val.TextAlignment;
            _rowSpacing = val.RowSpacing;
            _wordwrap = val.Wordwrap;
            _textEffect = val.TextEffect;
            _effectShadowOffset = val.EffectShadowOffset;
            _effectStrokeThickness = val.EffectStrokeThickness;
            _effectRoundStroke = val.EffectRoundStroke;
            _effectColor = val.EffectColor;
            _effectDepthBias = val.EffectDepthBias;
            _width = val.Width;
            _opacity = val.Opacity;
            _fixedScreenSize = val.FixedScreenSize;
            _faceCameraMode = val.FaceCameraMode;
            _drawDistance = val.DrawDistance;
            _shadowDistance = val.ShadowDistance;
            _lodBias = val.LodBias;
            _viewMask = val.ViewMask;
            _lightMask = val.LightMask;
            _shadowMask = val.ShadowMask;
            _zoneMask = val.ZoneMask;
            _maxLights = val.MaxLights;
            _castShadows = val.CastShadows;
            _occluder = val.Occluder;
            _occludee = val.Occludee;
            _sortValue = val.SortValue;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float FontSize {get { return _fontSize;} set { _fontSize=value; } }
        public bool FontSizeHasValue {get { return !PrefabUtils.AreEqual(ref _fontSize, ref FontSizeDefaultValue); } }
        public Material Material {get { return _material;} set { _material=value; } }
        public bool MaterialHasValue {get { return !PrefabUtils.AreEqual(ref _material, ref MaterialDefaultValue); } }
        public String Text {get { return _text;} set { _text=value; } }
        public bool TextHasValue {get { return !PrefabUtils.AreEqual(ref _text, ref TextDefaultValue); } }
        public HorizontalAlignment HorizontalAlignment {get { return _horizontalAlignment;} set { _horizontalAlignment=value; } }
        public bool HorizontalAlignmentHasValue {get { return !PrefabUtils.AreEqual(ref _horizontalAlignment, ref HorizontalAlignmentDefaultValue); } }
        public VerticalAlignment VerticalAlignment {get { return _verticalAlignment;} set { _verticalAlignment=value; } }
        public bool VerticalAlignmentHasValue {get { return !PrefabUtils.AreEqual(ref _verticalAlignment, ref VerticalAlignmentDefaultValue); } }
        public HorizontalAlignment TextAlignment {get { return _textAlignment;} set { _textAlignment=value; } }
        public bool TextAlignmentHasValue {get { return !PrefabUtils.AreEqual(ref _textAlignment, ref TextAlignmentDefaultValue); } }
        public float RowSpacing {get { return _rowSpacing;} set { _rowSpacing=value; } }
        public bool RowSpacingHasValue {get { return !PrefabUtils.AreEqual(ref _rowSpacing, ref RowSpacingDefaultValue); } }
        public bool Wordwrap {get { return _wordwrap;} set { _wordwrap=value; } }
        public bool WordwrapHasValue {get { return !PrefabUtils.AreEqual(ref _wordwrap, ref WordwrapDefaultValue); } }
        public TextEffect TextEffect {get { return _textEffect;} set { _textEffect=value; } }
        public bool TextEffectHasValue {get { return !PrefabUtils.AreEqual(ref _textEffect, ref TextEffectDefaultValue); } }
        public IntVector2 EffectShadowOffset {get { return _effectShadowOffset;} set { _effectShadowOffset=value; } }
        public bool EffectShadowOffsetHasValue {get { return !PrefabUtils.AreEqual(ref _effectShadowOffset, ref EffectShadowOffsetDefaultValue); } }
        public int EffectStrokeThickness {get { return _effectStrokeThickness;} set { _effectStrokeThickness=value; } }
        public bool EffectStrokeThicknessHasValue {get { return !PrefabUtils.AreEqual(ref _effectStrokeThickness, ref EffectStrokeThicknessDefaultValue); } }
        public bool EffectRoundStroke {get { return _effectRoundStroke;} set { _effectRoundStroke=value; } }
        public bool EffectRoundStrokeHasValue {get { return !PrefabUtils.AreEqual(ref _effectRoundStroke, ref EffectRoundStrokeDefaultValue); } }
        public Color EffectColor {get { return _effectColor;} set { _effectColor=value; } }
        public bool EffectColorHasValue {get { return !PrefabUtils.AreEqual(ref _effectColor, ref EffectColorDefaultValue); } }
        public float EffectDepthBias {get { return _effectDepthBias;} set { _effectDepthBias=value; } }
        public bool EffectDepthBiasHasValue {get { return !PrefabUtils.AreEqual(ref _effectDepthBias, ref EffectDepthBiasDefaultValue); } }
        public int Width {get { return _width;} set { _width=value; } }
        public bool WidthHasValue {get { return !PrefabUtils.AreEqual(ref _width, ref WidthDefaultValue); } }
        public float Opacity {get { return _opacity;} set { _opacity=value; } }
        public bool OpacityHasValue {get { return !PrefabUtils.AreEqual(ref _opacity, ref OpacityDefaultValue); } }
        public bool FixedScreenSize {get { return _fixedScreenSize;} set { _fixedScreenSize=value; } }
        public bool FixedScreenSizeHasValue {get { return !PrefabUtils.AreEqual(ref _fixedScreenSize, ref FixedScreenSizeDefaultValue); } }
        public FaceCameraMode FaceCameraMode {get { return _faceCameraMode;} set { _faceCameraMode=value; } }
        public bool FaceCameraModeHasValue {get { return !PrefabUtils.AreEqual(ref _faceCameraMode, ref FaceCameraModeDefaultValue); } }
        public float DrawDistance {get { return _drawDistance;} set { _drawDistance=value; } }
        public bool DrawDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _drawDistance, ref DrawDistanceDefaultValue); } }
        public float ShadowDistance {get { return _shadowDistance;} set { _shadowDistance=value; } }
        public bool ShadowDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _shadowDistance, ref ShadowDistanceDefaultValue); } }
        public float LodBias {get { return _lodBias;} set { _lodBias=value; } }
        public bool LodBiasHasValue {get { return !PrefabUtils.AreEqual(ref _lodBias, ref LodBiasDefaultValue); } }
        public uint ViewMask {get { return _viewMask;} set { _viewMask=value; } }
        public bool ViewMaskHasValue {get { return !PrefabUtils.AreEqual(ref _viewMask, ref ViewMaskDefaultValue); } }
        public uint LightMask {get { return _lightMask;} set { _lightMask=value; } }
        public bool LightMaskHasValue {get { return !PrefabUtils.AreEqual(ref _lightMask, ref LightMaskDefaultValue); } }
        public uint ShadowMask {get { return _shadowMask;} set { _shadowMask=value; } }
        public bool ShadowMaskHasValue {get { return !PrefabUtils.AreEqual(ref _shadowMask, ref ShadowMaskDefaultValue); } }
        public uint ZoneMask {get { return _zoneMask;} set { _zoneMask=value; } }
        public bool ZoneMaskHasValue {get { return !PrefabUtils.AreEqual(ref _zoneMask, ref ZoneMaskDefaultValue); } }
        public uint MaxLights {get { return _maxLights;} set { _maxLights=value; } }
        public bool MaxLightsHasValue {get { return !PrefabUtils.AreEqual(ref _maxLights, ref MaxLightsDefaultValue); } }
        public bool CastShadows {get { return _castShadows;} set { _castShadows=value; } }
        public bool CastShadowsHasValue {get { return !PrefabUtils.AreEqual(ref _castShadows, ref CastShadowsDefaultValue); } }
        public bool Occluder {get { return _occluder;} set { _occluder=value; } }
        public bool OccluderHasValue {get { return !PrefabUtils.AreEqual(ref _occluder, ref OccluderDefaultValue); } }
        public bool Occludee {get { return _occludee;} set { _occludee=value; } }
        public bool OccludeeHasValue {get { return !PrefabUtils.AreEqual(ref _occludee, ref OccludeeDefaultValue); } }
        public float SortValue {get { return _sortValue;} set { _sortValue=value; } }
        public bool SortValueHasValue {get { return !PrefabUtils.AreEqual(ref _sortValue, ref SortValueDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Text3D Create()
        {
            var result = new Text3D();
            if(FontSizeHasValue)
                result.FontSize = _fontSize;
            if(MaterialHasValue)
                result.Material = _material;
            if(TextHasValue)
                result.Text = _text;
            if(HorizontalAlignmentHasValue)
                result.HorizontalAlignment = _horizontalAlignment;
            if(VerticalAlignmentHasValue)
                result.VerticalAlignment = _verticalAlignment;
            if(TextAlignmentHasValue)
                result.TextAlignment = _textAlignment;
            if(RowSpacingHasValue)
                result.RowSpacing = _rowSpacing;
            if(WordwrapHasValue)
                result.Wordwrap = _wordwrap;
            if(TextEffectHasValue)
                result.TextEffect = _textEffect;
            if(EffectShadowOffsetHasValue)
                result.EffectShadowOffset = _effectShadowOffset;
            if(EffectStrokeThicknessHasValue)
                result.EffectStrokeThickness = _effectStrokeThickness;
            if(EffectRoundStrokeHasValue)
                result.EffectRoundStroke = _effectRoundStroke;
            if(EffectColorHasValue)
                result.EffectColor = _effectColor;
            if(EffectDepthBiasHasValue)
                result.EffectDepthBias = _effectDepthBias;
            if(WidthHasValue)
                result.Width = _width;
            if(OpacityHasValue)
                result.Opacity = _opacity;
            if(FixedScreenSizeHasValue)
                result.FixedScreenSize = _fixedScreenSize;
            if(FaceCameraModeHasValue)
                result.FaceCameraMode = _faceCameraMode;
            if(DrawDistanceHasValue)
                result.DrawDistance = _drawDistance;
            if(ShadowDistanceHasValue)
                result.ShadowDistance = _shadowDistance;
            if(LodBiasHasValue)
                result.LodBias = _lodBias;
            if(ViewMaskHasValue)
                result.ViewMask = _viewMask;
            if(LightMaskHasValue)
                result.LightMask = _lightMask;
            if(ShadowMaskHasValue)
                result.ShadowMask = _shadowMask;
            if(ZoneMaskHasValue)
                result.ZoneMask = _zoneMask;
            if(MaxLightsHasValue)
                result.MaxLights = _maxLights;
            if(CastShadowsHasValue)
                result.CastShadows = _castShadows;
            if(OccluderHasValue)
                result.Occluder = _occluder;
            if(OccludeeHasValue)
                result.Occludee = _occludee;
            if(SortValueHasValue)
                result.SortValue = _sortValue;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "FontSize":
                    break;
                case "Material":
                    break;
                case "Text":
                    break;
                case "HorizontalAlignment":
                    break;
                case "VerticalAlignment":
                    break;
                case "TextAlignment":
                    break;
                case "RowSpacing":
                    break;
                case "Wordwrap":
                    break;
                case "TextEffect":
                    break;
                case "EffectShadowOffset":
                    break;
                case "EffectStrokeThickness":
                    break;
                case "EffectRoundStroke":
                    break;
                case "EffectColor":
                    break;
                case "EffectDepthBias":
                    break;
                case "Width":
                    break;
                case "Opacity":
                    break;
                case "FixedScreenSize":
                    break;
                case "FaceCameraMode":
                    break;
                case "DrawDistance":
                    break;
                case "ShadowDistance":
                    break;
                case "LodBias":
                    break;
                case "ViewMask":
                    break;
                case "LightMask":
                    break;
                case "ShadowMask":
                    break;
                case "ZoneMask":
                    break;
                case "MaxLights":
                    break;
                case "CastShadows":
                    break;
                case "Occluder":
                    break;
                case "Occludee":
                    break;
                case "SortValue":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}
