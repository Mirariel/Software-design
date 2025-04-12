﻿public abstract class LightNode
{
    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }

    public abstract void RenderIndented(TextWriter writer, int indent = 0);
}