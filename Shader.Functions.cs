#pragma warning disable

public abstract partial class Shader
{
    // Angle & Trigonometry Functions

    protected extern float radians(float degrees);
    protected extern vec2 radians(vec2 degrees);
    protected extern vec3 radians(vec3 degrees);
    protected extern vec4 radians(vec4 degrees);

    protected extern float degrees(float radians);
    protected extern vec2 degrees(vec2 radians);
    protected extern vec3 degrees(vec3 radians);
    protected extern vec4 degrees(vec4 radians);

    protected extern float sin(float angle);
    protected extern vec2 sin(vec2 angle);
    protected extern vec3 sin(vec3 angle);
    protected extern vec4 sin(vec4 angle);

    protected extern float cos(float angle);
    protected extern vec2 cos(vec2 angle);
    protected extern vec3 cos(vec3 angle);
    protected extern vec4 cos(vec4 angle);

    protected extern float tan(float angle);
    protected extern vec2 tan(vec2 angle);
    protected extern vec3 tan(vec3 angle);
    protected extern vec4 tan(vec4 angle);

    protected extern float asin(float angle);
    protected extern vec2 asin(vec2 angle);
    protected extern vec3 asin(vec3 angle);
    protected extern vec4 asin(vec4 angle);

    protected extern float acos(float angle);
    protected extern vec2 acos(vec2 angle);
    protected extern vec3 acos(vec3 angle);
    protected extern vec4 acos(vec4 angle);

    protected extern float atan(float y, float x);
    protected extern vec2 atan(vec2 y, vec2 x);
    protected extern vec3 atan(vec3 y, vec3 x);
    protected extern vec4 atan(vec4 y, vec4 x);

    protected extern float atan(float yOverX);
    protected extern vec2 atan(vec2 yOverX);
    protected extern vec3 atan(vec3 yOverX);
    protected extern vec4 atan(vec4 yOverX);

    protected extern float sinh(float x);
    protected extern vec2 sinh(vec2 x);
    protected extern vec3 sinh(vec3 x);
    protected extern vec4 sinh(vec4 x);

    protected extern float cosh(float x);
    protected extern vec2 cosh(vec2 x);
    protected extern vec3 cosh(vec3 x);
    protected extern vec4 cosh(vec4 x);

    protected extern float tanh(float x);
    protected extern vec2 tanh(vec2 x);
    protected extern vec3 tanh(vec3 x);
    protected extern vec4 tanh(vec4 x);

    protected extern float asinh(float x);
    protected extern vec2 asinh(vec2 x);
    protected extern vec3 asinh(vec3 x);
    protected extern vec4 asinh(vec4 x);

    protected extern float acosh(float x);
    protected extern vec2 acosh(vec2 x);
    protected extern vec3 acosh(vec3 x);
    protected extern vec4 acosh(vec4 x);

    protected extern float atanh(float x);
    protected extern vec2 atanh(vec2 x);
    protected extern vec3 atanh(vec3 x);
    protected extern vec4 atanh(vec4 x);

    // Exponential Functions

    protected extern float pow(float x, float y);
    protected extern vec2 pow(vec2 x, vec2 y);
    protected extern vec3 pow(vec3 x, vec3 y);
    protected extern vec4 pow(vec4 x, vec4 y);

    protected extern float exp(float x);
    protected extern vec2 exp(vec2 x);
    protected extern vec3 exp(vec3 x);
    protected extern vec4 exp(vec4 x);

    protected extern float log(float x);
    protected extern vec2 log(vec2 x);
    protected extern vec3 log(vec3 x);
    protected extern vec4 log(vec4 x);

    protected extern float exp2(float x);
    protected extern vec2 exp2(vec2 x);
    protected extern vec3 exp2(vec3 x);
    protected extern vec4 exp2(vec4 x);

    protected extern float log2(float x);
    protected extern vec2 log2(vec2 x);
    protected extern vec3 log2(vec3 x);
    protected extern vec4 log2(vec4 x);

    protected extern float sqrt(float x);
    protected extern vec2 sqrt(vec2 x);
    protected extern vec3 sqrt(vec3 x);
    protected extern vec4 sqrt(vec4 x);

    protected extern float inversesqrt(float x);
    protected extern vec2 inversesqrt(vec2 x);
    protected extern vec3 inversesqrt(vec3 x);
    protected extern vec4 inversesqrt(vec4 x);

    // Common Functions

    protected extern float abs(float x);
    protected extern vec2 abs(vec2 x);
    protected extern vec3 abs(vec3 x);
    protected extern vec4 abs(vec4 x);
    protected extern int abs(int x);
    protected extern ivec2 abs(ivec2 x);
    protected extern ivec3 abs(ivec3 x);
    protected extern ivec4 abs(ivec4 x);

    protected extern float sign(float x);
    protected extern vec2 sign(vec2 x);
    protected extern vec3 sign(vec3 x);
    protected extern vec4 sign(vec4 x);
    protected extern int sign(int x);
    protected extern ivec2 sign(ivec2 x);
    protected extern ivec3 sign(ivec3 x);
    protected extern ivec4 sign(ivec4 x);

    protected extern float floor(float x);
    protected extern vec2 floor(vec2 x);
    protected extern vec3 floor(vec3 x);
    protected extern vec4 floor(vec4 x);

    protected extern float trunc(float x);
    protected extern vec2 trunc(vec2 x);
    protected extern vec3 trunc(vec3 x);
    protected extern vec4 trunc(vec4 x);

    protected extern float round(float x);
    protected extern vec2 round(vec2 x);
    protected extern vec3 round(vec3 x);
    protected extern vec4 round(vec4 x);

    protected extern float roundEven(float x);
    protected extern vec2 roundEven(vec2 x);
    protected extern vec3 roundEven(vec3 x);
    protected extern vec4 roundEven(vec4 x);

    protected extern float ceil(float x);
    protected extern vec2 ceil(vec2 x);
    protected extern vec3 ceil(vec3 x);
    protected extern vec4 ceil(vec4 x);

    protected extern float fract(float x);
    protected extern vec2 fract(vec2 x);
    protected extern vec3 fract(vec3 x);
    protected extern vec4 fract(vec4 x);

    protected extern float mod(float x, float y);
    protected extern vec2 mod(vec2 x, vec2 y);
    protected extern vec3 mod(vec3 x, vec3 y);
    protected extern vec4 mod(vec4 x, vec4 y);
    protected extern vec2 mod(vec2 x, float y);
    protected extern vec3 mod(vec3 x, float y);
    protected extern vec4 mod(vec4 x, float y);

    protected extern float modf(float x, out float y);
    protected extern vec2 modf(vec2 x, out vec2 y);
    protected extern vec3 modf(vec3 x, out vec3 y);
    protected extern vec4 modf(vec4 x, out vec4 y);

    protected extern float min(float x, float y);
    protected extern vec2 min(vec2 x, vec2 y);
    protected extern vec3 min(vec3 x, vec3 y);
    protected extern vec4 min(vec4 x, vec4 y);
    protected extern vec2 min(vec2 x, float y);
    protected extern vec3 min(vec3 x, float y);
    protected extern vec4 min(vec4 x, float y);
    protected extern int min(int x, int y);
    protected extern ivec2 min(ivec2 x, ivec2 y);
    protected extern ivec3 min(ivec3 x, ivec3 y);
    protected extern ivec4 min(ivec4 x, ivec4 y);
    protected extern ivec2 min(ivec2 x, int y);
    protected extern ivec3 min(ivec3 x, int y);
    protected extern ivec4 min(ivec4 x, int y);
    protected extern uint min(uint x, uint y);
    protected extern uivec2 min(uivec2 x, uivec2 y);
    protected extern uivec3 min(uivec3 x, uivec3 y);
    protected extern uivec4 min(uivec4 x, uivec4 y);
    protected extern uivec2 min(uivec2 x, uint y);
    protected extern uivec3 min(uivec3 x, uint y);
    protected extern uivec4 min(uivec4 x, uint y);

    protected extern float max(float x, float y);
    protected extern vec2 max(vec2 x, vec2 y);
    protected extern vec3 max(vec3 x, vec3 y);
    protected extern vec4 max(vec4 x, vec4 y);
    protected extern vec2 max(vec2 x, float y);
    protected extern vec3 max(vec3 x, float y);
    protected extern vec4 max(vec4 x, float y);
    protected extern int max(int x, int y);
    protected extern ivec2 max(ivec2 x, ivec2 y);
    protected extern ivec3 max(ivec3 x, ivec3 y);
    protected extern ivec4 max(ivec4 x, ivec4 y);
    protected extern ivec2 max(ivec2 x, int y);
    protected extern ivec3 max(ivec3 x, int y);
    protected extern ivec4 max(ivec4 x, int y);
    protected extern uint max(uint x, uint y);
    protected extern uivec2 max(uivec2 x, uivec2 y);
    protected extern uivec3 max(uivec3 x, uivec3 y);
    protected extern uivec4 max(uivec4 x, uivec4 y);
    protected extern uivec2 max(uivec2 x, uint y);
    protected extern uivec3 max(uivec3 x, uint y);
    protected extern uivec4 max(uivec4 x, uint y);

    protected extern float clamp(float x, float minVal, float maxVal);
    protected extern vec2 clamp(vec2 x, vec2 minVal, vec2 maxVal);
    protected extern vec3 clamp(vec3 x, vec3 minVal, vec3 maxVal);
    protected extern vec4 clamp(vec4 x, vec4 minVal, vec4 maxVal);
    protected extern vec2 clamp(vec2 x, float minVal, float maxVal);
    protected extern vec3 clamp(vec3 x, float minVal, float maxVal);
    protected extern vec4 clamp(vec4 x, float minVal, float maxVal);
    protected extern int clamp(int x, int minVal, int maxVal);
    protected extern ivec2 clamp(ivec2 x, ivec2 minVal, ivec2 maxVal);
    protected extern ivec3 clamp(ivec3 x, ivec3 minVal, ivec3 maxVal);
    protected extern ivec4 clamp(ivec4 x, ivec4 minVal, ivec4 maxVal);
    protected extern ivec2 clamp(ivec2 x, int minVal, int maxVal);
    protected extern ivec3 clamp(ivec3 x, int minVal, int maxVal);
    protected extern ivec4 clamp(ivec4 x, int minVal, int maxVal);
    protected extern uint clamp(uint x, uint y);
    protected extern uivec2 clamp(uivec2 x, uivec2 minVal, uivec2 maxVal);
    protected extern uivec3 clamp(uivec3 x, uivec3 minVal, uivec3 maxVal);
    protected extern uivec4 clamp(uivec4 x, uivec4 minVal, uivec4 maxVal);
    protected extern uivec2 clamp(uivec2 x, uint minVal, uint maxVal);
    protected extern uivec3 clamp(uivec3 x, uint minVal, uint maxVal);
    protected extern uivec4 clamp(uivec4 x, uint minVal, uint maxVal);

    protected extern float mix(float x, float y, float a);
    protected extern vec2 mix(vec2 x, vec2 y, vec2 a);
    protected extern vec3 mix(vec3 x, vec3 y, vec3 a);
    protected extern vec4 mix(vec4 x, vec4 y, vec4 a);
    protected extern vec2 mix(vec2 x, vec2 y, float a);
    protected extern vec3 mix(vec3 x, vec2 y, float a);
    protected extern vec4 mix(vec4 x, vec2 y, float a);
    protected extern vec2 mix(float x, float y, bool a);
    protected extern vec2 mix(vec2 x, vec2 y, bvec2 a);
    protected extern vec3 mix(vec3 x, vec3 y, bvec3 a);
    protected extern vec4 mix(vec4 x, vec4 y, bvec4 a);

    protected extern float step(float edge, float x);
    protected extern vec2 step(vec2 edge, vec2 x);
    protected extern vec3 step(vec3 edge, vec3 x);
    protected extern vec4 step(vec4 edge, vec4 x);
    protected extern vec2 step(float edge, vec2 x);
    protected extern vec3 step(float edge, vec3 x);
    protected extern vec4 step(float edge, vec4 x);

    protected extern float smoothstep(float edge0, float edge1, float x);
    protected extern vec2 smoothstep(vec2 edge0, vec2 edge1, vec2 x);
    protected extern vec3 smoothstep(vec3 edge0, vec2 edge1, vec3 x);
    protected extern vec4 smoothstep(vec4 edge0, vec2 edge1, vec4 x);
    protected extern vec2 smoothstep(float edge0, float edge1, vec2 x);
    protected extern vec3 smoothstep(float edge0, float edge1, vec3 x);
    protected extern vec4 smoothstep(float edge0, float edge1, vec4 x);

    protected extern bool isnan(float x);
    protected extern bvec2 isnan(vec2 x);
    protected extern bvec3 isnan(vec3 x);
    protected extern bvec4 isnan(vec4 x);

    protected extern bool isinf(float x);
    protected extern bvec2 isinf(vec2 x);
    protected extern bvec3 isinf(vec3 x);
    protected extern bvec4 isinf(vec4 x);

    // Geometric Functions

    protected extern float length(float x);
    protected extern float length(vec2 x);
    protected extern float length(vec3 x);
    protected extern float length(vec4 x);

    protected extern float dot(float x);
    protected extern float dot(vec2 x);
    protected extern float dot(vec3 x);
    protected extern float dot(vec4 x);

    protected extern vec3 cross(vec3 x);

    protected extern float normalize(float x);
    protected extern vec2 normalize(vec2 x);
    protected extern vec3 normalize(vec3 x);
    protected extern vec4 normalize(vec4 x);

    protected extern vec4 ftransform();

    protected extern float faceforward(float N, float I, float Nref);
    protected extern vec2 faceforward(vec2 N, vec2 I, vec2 Nref);
    protected extern vec3 faceforward(vec3 N, vec3 I, vec3 Nref);
    protected extern vec4 faceforward(vec4 N, vec4 I, vec4 Nref);

    protected extern float reflect(float I, float N);
    protected extern vec2 reflect(vec2 I, vec2 N);
    protected extern vec3 reflect(vec3 I, vec3 N);
    protected extern vec4 reflect(vec4 I, vec4 N);

    protected extern float refract(float I, float N, float eta);
    protected extern vec2 refract(vec2 I, vec2 N, float eta);
    protected extern vec3 refract(vec3 I, vec3 N, float eta);
    protected extern vec4 refract(vec4 I, vec4 N, float eta);

    // Matrix Functions

    protected extern mat2 matrixCompMult(mat2 x, mat2 y);
    protected extern mat3 matrixCompMult(mat3 x, mat3 y);
    protected extern mat4 matrixCompMult(mat4 x, mat4 y);
    protected extern mat2x3 matrixCompMult(mat2x3 x, mat2x3 y);
    protected extern mat2x4 matrixCompMult(mat2x4 x, mat2x4 y);
    protected extern mat3x2 matrixCompMult(mat3x2 x, mat3x2 y);
    protected extern mat3x4 matrixCompMult(mat3x4 x, mat3x4 y);
    protected extern mat4x2 matrixCompMult(mat4x2 x, mat4x2 y);
    protected extern mat4x3 matrixCompMult(mat4x3 x, mat4x3 y);

    protected extern mat2 outerProduct(vec2 c, vec2 r);
    protected extern mat3 outerProduct(vec3 c, vec3 r);
    protected extern mat4 outerProduct(vec4 c, vec4 r);
    protected extern mat2x3 outerProduct(vec3 c, vec2 r);
    protected extern mat2x4 outerProduct(vec4 c, vec2 r);
    protected extern mat3x2 outerProduct(vec2 c, vec3 r);
    protected extern mat3x4 outerProduct(vec4 c, vec3 r);
    protected extern mat4x2 outerProduct(vec2 c, vec4 r);
    protected extern mat4x3 outerProduct(vec3 c, vec4 r);

    protected extern mat2 transpose(mat2 m);
    protected extern mat3 transpose(mat3 m);
    protected extern mat4 transpose(mat4 m);
    protected extern mat2x3 transpose(mat3x2 m);
    protected extern mat2x4 transpose(mat4x2 m);
    protected extern mat3x2 transpose(mat2x3 m);
    protected extern mat3x4 transpose(mat4x3 m);
    protected extern mat4x2 transpose(mat2x4 m);
    protected extern mat4x3 transpose(mat3x4 m);

    protected extern mat2 determinant(mat2 m);
    protected extern mat3 determinant(mat3 m);
    protected extern mat4 determinant(mat4 m);

    protected extern mat2 inverse(mat2 m);
    protected extern mat3 inverse(mat3 m);
    protected extern mat4 inverse(mat4 m);

    // Vector Relational Functions

    protected extern bvec2 lessThan(vec2 x, vec2 y);
    protected extern bvec3 lessThan(vec3 x, vec3 y);
    protected extern bvec4 lessThan(vec4 x, vec4 y);
    protected extern bvec2 lessThan(ivec2 x, ivec2 y);
    protected extern bvec3 lessThan(ivec3 x, ivec3 y);
    protected extern bvec4 lessThan(ivec4 x, ivec4 y);
    protected extern bvec2 lessThan(uivec2 x, uivec2 y);
    protected extern bvec3 lessThan(uivec3 x, uivec3 y);
    protected extern bvec4 lessThan(uivec4 x, uivec4 y);

    protected extern bvec2 lessThanEqual(vec2 x, vec2 y);
    protected extern bvec3 lessThanEqual(vec3 x, vec3 y);
    protected extern bvec4 lessThanEqual(vec4 x, vec4 y);
    protected extern bvec2 lessThanEqual(ivec2 x, ivec2 y);
    protected extern bvec3 lessThanEqual(ivec3 x, ivec3 y);
    protected extern bvec4 lessThanEqual(ivec4 x, ivec4 y);
    protected extern bvec2 lessThanEqual(uivec2 x, uivec2 y);
    protected extern bvec3 lessThanEqual(uivec3 x, uivec3 y);
    protected extern bvec4 lessThanEqual(uivec4 x, uivec4 y);

    protected extern bvec2 greaterThan(vec2 x, vec2 y);
    protected extern bvec3 greaterThan(vec3 x, vec3 y);
    protected extern bvec4 greaterThan(vec4 x, vec4 y);
    protected extern bvec2 greaterThan(ivec2 x, ivec2 y);
    protected extern bvec3 greaterThan(ivec3 x, ivec3 y);
    protected extern bvec4 greaterThan(ivec4 x, ivec4 y);
    protected extern bvec2 greaterThan(uivec2 x, uivec2 y);
    protected extern bvec3 greaterThan(uivec3 x, uivec3 y);
    protected extern bvec4 greaterThan(uivec4 x, uivec4 y);

    protected extern bvec2 greaterThanEqual(vec2 x, vec2 y);
    protected extern bvec3 greaterThanEqual(vec3 x, vec3 y);
    protected extern bvec4 greaterThanEqual(vec4 x, vec4 y);
    protected extern bvec2 greaterThanEqual(ivec2 x, ivec2 y);
    protected extern bvec3 greaterThanEqual(ivec3 x, ivec3 y);
    protected extern bvec4 greaterThanEqual(ivec4 x, ivec4 y);
    protected extern bvec2 greaterThanEqual(uivec2 x, uivec2 y);
    protected extern bvec3 greaterThanEqual(uivec3 x, uivec3 y);
    protected extern bvec4 greaterThanEqual(uivec4 x, uivec4 y);

    protected extern bvec2 equal(vec2 x, vec2 y);
    protected extern bvec3 equal(vec3 x, vec3 y);
    protected extern bvec4 equal(vec4 x, vec4 y);
    protected extern bvec2 equal(ivec2 x, ivec2 y);
    protected extern bvec3 equal(ivec3 x, ivec3 y);
    protected extern bvec4 equal(ivec4 x, ivec4 y);
    protected extern bvec2 equal(uivec2 x, uivec2 y);
    protected extern bvec3 equal(uivec3 x, uivec3 y);
    protected extern bvec4 equal(uivec4 x, uivec4 y);
    protected extern bvec2 equal(bvec2 x, bvec2 y);
    protected extern bvec3 equal(bvec3 x, bvec3 y);
    protected extern bvec4 equal(bvec4 x, bvec4 y);

    protected extern bvec2 notEqual(vec2 x, vec2 y);
    protected extern bvec3 notEqual(vec3 x, vec3 y);
    protected extern bvec4 notEqual(vec4 x, vec4 y);
    protected extern bvec2 notEqual(ivec2 x, ivec2 y);
    protected extern bvec3 notEqual(ivec3 x, ivec3 y);
    protected extern bvec4 notEqual(ivec4 x, ivec4 y);
    protected extern bvec2 notEqual(uivec2 x, uivec2 y);
    protected extern bvec3 notEqual(uivec3 x, uivec3 y);
    protected extern bvec4 notEqual(uivec4 x, uivec4 y);
    protected extern bvec2 notEqual(bvec2 x, bvec2 y);
    protected extern bvec3 notEqual(bvec3 x, bvec3 y);
    protected extern bvec4 notEqual(bvec4 x, bvec4 y);

    protected extern bvec2 all(bvec2 x, bvec2 y);
    protected extern bvec3 all(bvec3 x, bvec3 y);
    protected extern bvec4 all(bvec4 x, bvec4 y);

    protected extern bvec2 any(bvec2 x, bvec2 y);
    protected extern bvec3 any(bvec3 x, bvec3 y);
    protected extern bvec4 any(bvec4 x, bvec4 y);

    protected extern bvec2 not(bvec2 x, bvec2 y);
    protected extern bvec3 not(bvec3 x, bvec3 y);
    protected extern bvec4 not(bvec4 x, bvec4 y);
}

public abstract partial class FragmentShader
{
    // Derivative Functions

    protected extern float dFdx(float p);
    protected extern vec2 dFdx(vec2 p);
    protected extern vec3 dFdx(vec3 p);
    protected extern vec4 dFdx(vec4 p);

    protected extern float dFdy(float p);
    protected extern vec2 dFdy(vec2 p);
    protected extern vec3 dFdy(vec3 p);
    protected extern vec4 dFdy(vec4 p);

    protected extern float fwidth(float p);
    protected extern vec2 fwidth(vec2 p);
    protected extern vec3 fwidth(vec3 p);
    protected extern vec4 fwidth(vec4 p);
}

public abstract partial class RenderShader
{
    // Noise Functions

    protected extern float noise1(float p);
    protected extern float noise1(vec2 p);
    protected extern float noise1(vec3 p);
    protected extern float noise1(vec4 p);

    protected extern vec2 noise2(float p);
    protected extern vec2 noise2(vec2 p);
    protected extern vec2 noise2(vec3 p);
    protected extern vec2 noise2(vec4 p);

    protected extern vec3 noise3(float p);
    protected extern vec3 noise3(vec2 p);
    protected extern vec3 noise3(vec3 p);
    protected extern vec3 noise3(vec4 p);

    protected extern vec4 noise4(float p);
    protected extern vec4 noise4(vec2 p);
    protected extern vec4 noise4(vec3 p);
    protected extern vec4 noise4(vec4 p);
}

public abstract partial class GeometryShader
{
    // Geometry Shader Functons
    protected extern void EmitVertex();
    protected extern void EndPrimative();
}

#pragma warning restore