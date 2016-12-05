#pragma warning disable

public abstract partial class Shader
{
    // Floating Point Sampler Types
    protected struct sampler1D {}
    protected struct sampler2D {}
    protected struct sampler3D {}
    protected struct sampler4D {}
    protected struct samplerCube {}
    protected struct samplerCubeShadow {}
    protected struct sampler2DRect {}
    protected struct sampler1DShadow {}
    protected struct sampler2DShadow {}
    protected struct sampler2DRectShadow {}
    protected struct sampler1DArray {}
    protected struct sampler2DArray {}
    protected struct sampler1DArrayShadow {}
    protected struct sampler2DArrayShadow {}
    protected struct samplerBuffer {}
    protected struct sampler2DMS {}
    protected struct sampler2DMSArray {}

    // Integer Sampler Types

    protected struct isampler1D {}
    protected struct isampler2D {}
    protected struct isampler3D {}
    protected struct isampler4D {}
    protected struct isamplerCube {}
    protected struct isampler2DRect {}
    protected struct isampler1DArray {}
    protected struct isampler2DArray {}
    protected struct isamplerBuffer {}
    protected struct isampler2DMS {}
    protected struct isampler2DMSArray {}

    // Unsigned Integer Sampler Types

    protected struct usampler1D {}
    protected struct usampler2D {}
    protected struct usampler3D {}
    protected struct usampler4D {}
    protected struct usamplerCube {}
    protected struct usampler2DRect {}
    protected struct usampler1DArray {}
    protected struct usampler2DArray {}
    protected struct usamplerBuffer {}
    protected struct usampler2DMS {}
    protected struct usampler2DMSArray {}
}