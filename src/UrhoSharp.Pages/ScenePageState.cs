namespace UrhoSharp.Pages
{
    public enum ScenePageState
    {
        /// <summary>
        ///     Page is created but not in use at the moment.
        ///     It can go to "Preparing" from this state.
        /// </summary>
        NotActive,

        /// <summary>
        ///     Page is asyncroniously loading content.
        ///     It can go to "Paused" from this state.
        /// </summary>
        Preparing,

        /// <summary>
        ///     Page is paused.
        ///     It can go to "Active" or "NotActive" from this state.
        /// </summary>
        Paused,

        /// <summary>
        ///     Page is active.
        ///     It can go to "Paused" from this state.
        /// </summary>
        Active
    }
}