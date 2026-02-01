#if UNIRX_ENABLED

public static class UniRxUtils
{
    /// <summary>
    /// Use this because MainThreadDispatcher.Initialize() not working in VContainer
    /// </summary>
    public static void Initialize()
    {
        if (!Object.FindObjectOfType<MainThreadDispatcher>())
        {
            new GameObject("MainThreadDispatcher").AddComponent<MainThreadDispatcher>();
        }
    }
}

#endif