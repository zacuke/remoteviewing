namespace RemoteViewing.Vnc
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public interface IVncFramebuffer
    {
        int Height { get; }

        string Name { get; }

        VncPixelFormat PixelFormat { get; }

        int Stride { get; }

        object SyncRoot { get; }

        int Width { get; }

        IVncFramebuffer Capture();

        byte[] GetBuffer();

        void SetPixel(int x, int y, byte[] color);

        void SetPixel(int x, int y, int color);

        #pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}