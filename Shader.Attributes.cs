using System;

public abstract partial class Shader
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    protected sealed class UniformAttribute : Attribute {}
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    protected sealed class InAttribute : Attribute {}
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    protected sealed class OutAttribute : Attribute {}
}