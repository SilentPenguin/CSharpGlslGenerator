public abstract partial class Shader
{
    protected struct DepthRangeParameters
    {
        public readonly float near;
        public readonly float far;
        public readonly float diff;
    }

    // built-in variables
    [Uniform] protected readonly DepthRangeParameters gl_DepthRange;
    // gl 4.2 only
    [Uniform] protected readonly int gl_NumSamples;

    // built in constants with their minimum values
    protected const int gl_MaxClipDistances = 8;
    protected const int gl_MaxClipPlanes = 8;
    protected const int gl_MaxDrawBuffers = 8;
    protected const int gl_MaxTextureUnits = 2;
    protected const int gl_MaxTextureCoords = 2;
    protected const int gl_MaxGeometryTextureImageUnits = 16;
    protected const int gl_MaxTextureImageUnits = 16;
    protected const int gl_MaxVertexAttribs = 16;
    protected const int gl_MaxVertexTextureImageUnits = 16;
    protected const int gl_MaxCombinedTextureImageUnits = 48;
    protected const int gl_MaxGeometryVaryingComponents = 64;
    protected const int gl_MaxVaryingComponents = 64;
    protected const int gl_MaxVaryingFloats = 64;
    protected const int gl_MaxGeometryOutputVertices = 256;
    protected const int gl_MaxFragmentUniformComponents = 1024;
    protected const int gl_MaxGeometryTotalOutputComponents = 1024;
    protected const int gl_MaxGeometryUniformComponents = 1024;
    protected const int gl_MaxVertexUniformComponents = 1024;

    // protected abstract void main(); 
}

/*
 * Base class where glsl noise functions are attached that vertex, 
 * fragment and geometry shaders can access.
 */
public abstract partial class RenderShader : Shader {}

public abstract class VertexShader : RenderShader
{
    // built-in variables
    [In] protected readonly int gl_VertexId;
    [In] protected readonly int gl_InstanceId;
    [Out] protected vec4 gl_Position;
    [Out] protected float gl_PointSize;
    [Out] protected float[] gl_ClipDistance;
}

public abstract class TessellationControlShader : Shader
{
    // built-in variables
    [In] protected readonly int gl_PatchVerticesIn;
    [In] protected readonly int gl_PrimitiveID;
    [In] protected readonly int gl_InvocationID;
    [Out] protected float[] gl_TessLevelOuter;
    [Out] protected float[] gl_TessLevelInner;
}

public abstract class TessellationEvaluationShader : Shader
{
    // built-in variables
    [In] protected readonly vec3 gl_TessCoord;
    [In] protected readonly int gl_PatchVerticesIn;
    [In] protected readonly int gl_PrimitiveID;
    [Out] protected vec4 gl_Position;
    [Out] protected float gl_PointSize;
    [Out] protected float[] gl_ClipDistance;
}

public abstract partial class GeometryShader : RenderShader
{
    // built-in variables
    [In] protected readonly int gl_PrimitiveIDIn;
    [In] protected readonly int gl_InvocationID;
    [Out] protected vec4 gl_Position;
    [Out] protected float gl_PointSize;
    [Out] protected float[] gl_ClipDistance;
    [Out] protected int gl_PrimitiveID;
    [Out] protected int gl_Layer;
    [Out] protected int gl_ViewportIndex;
}

public abstract partial class FragmentShader : RenderShader
{
    // built-in variables
    [In] protected readonly vec4 gl_FragCoord;
    [In] protected readonly  bool gl_FrontFacing;
    [In] protected readonly vec2 gl_PointCoord;
    [In] protected readonly float[] gl_ClipDistance;
    [In] protected readonly int gl_PrimitiveID;
    [Out] protected float gl_FragDepth;
    [Out] protected int[] gl_SampleMask;
    // gl 4.0 only. Accessing these built-in values will disable multi-sampling.
    [In] protected readonly int gl_SampleID;
    [In] protected readonly vec2 gl_SamplePosition;
    [In] protected readonly int[] gl_SampleMaskIn;
    // gl 4.3 only
    [In] protected readonly int gl_Layer;
    [In] protected readonly int gl_ViewportIndex;
}