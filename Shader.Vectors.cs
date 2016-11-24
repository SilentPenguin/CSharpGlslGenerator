public abstract partial class Shader
{
    protected struct bvec2
    {
        public extern bvec2(bool all);
        public extern bvec2(bool x, bool y);

        public extern bool x { get; set; }
        public extern bool y { get; set; }

        public extern bool r { get; set; }
        public extern bool g { get; set; }

        public extern bool s { get; set; }
        public extern bool t { get; set; }

        public extern bool this[int item]{ get; set; }

        public extern static bvec2 operator +(bvec2 left, bvec2 right);
        public extern static bvec2 operator -(bvec2 left, bvec2 right);
        public extern static bvec2 operator *(bvec2 left, bvec2 right);
        public extern static bvec2 operator /(bvec2 left, bvec2 right);
    }

    protected struct ivec2
    {
        public extern ivec2(int all);
        public extern ivec2(int x, int y);

        public extern int x { get; set; }
        public extern int y { get; set; }

        public extern int r { get; set; }
        public extern int g { get; set; }

        public extern int s { get; set; }
        public extern int t { get; set; }

        public extern int this[int item]{ get; set; }

        public extern static ivec2 operator +(ivec2 left, ivec2 right);
        public extern static ivec2 operator -(ivec2 left, ivec2 right);
        public extern static ivec2 operator *(ivec2 left, ivec2 right);
        public extern static ivec2 operator /(ivec2 left, ivec2 right);
    }

    protected struct uivec2
    {
        public extern uivec2(uint all);
        public extern uivec2(uint x, uint y);

        public extern uint x { get; set; }
        public extern uint y { get; set; }

        public extern uint r { get; set; }
        public extern uint g { get; set; }

        public extern uint s { get; set; }
        public extern uint t { get; set; }

        public extern uint this[int item]{ get; set; }

        public extern static uivec2 operator +(uivec2 left, uivec2 right);
        public extern static uivec2 operator -(uivec2 left, uivec2 right);
        public extern static uivec2 operator *(uivec2 left, uivec2 right);
        public extern static uivec2 operator /(uivec2 left, uivec2 right);
    }

    protected struct vec2
    {
        public extern vec2(float all);
        public extern vec2(float x, float y);

        public extern float x { get; set; }
        public extern float y { get; set; }

        public extern float r { get; set; }
        public extern float g { get; set; }

        public extern float s { get; set; }
        public extern float t { get; set; }

        public extern float this[int item]{ get; set; }

        public extern static vec2 operator +(vec2 left, vec2 right);
        public extern static vec2 operator -(vec2 left, vec2 right);
        public extern static vec2 operator *(vec2 left, vec2 right);
        public extern static vec2 operator /(vec2 left, vec2 right);
    }

    protected struct dvec2
    {
        public extern dvec2(double all);
        public extern dvec2(double x, double y);

        public extern double x { get; set; }
        public extern double y { get; set; }

        public extern double r { get; set; }
        public extern double b { get; set; }

        public extern double s { get; set; }
        public extern double t { get; set; }

        public extern double this[int item]{ get; set; }

        public extern static dvec2 operator +(dvec2 left, dvec2 right);
        public extern static dvec2 operator -(dvec2 left, dvec2 right);
        public extern static dvec2 operator *(dvec2 left, dvec2 right);
        public extern static dvec2 operator /(dvec2 left, dvec2 right);
    }

    protected struct bvec3
    {
        public extern bvec3(bool all);
        public extern bvec3(bvec2 xy, bool z);
        public extern bvec3(bool x, bvec2 yz);
        public extern bvec3(bool x, bool y, bool z);

        public extern bool x { get; set; }
        public extern bool y { get; set; }
        public extern bool z { get; set; }

        public extern bool r { get; set; }
        public extern bool g { get; set; }
        public extern bool b { get; set; }

        public extern bool s { get; set; }
        public extern bool t { get; set; }
        public extern bool p { get; set; }

        public extern bool this[int item]{ get; set; }

        public extern static bvec3 operator +(bvec3 left, bvec3 right);
        public extern static bvec3 operator -(bvec3 left, bvec3 right);
        public extern static bvec3 operator *(bvec3 left, bvec3 right);
        public extern static bvec3 operator /(bvec3 left, bvec3 right);
    }

    protected struct ivec3
    {
        public extern ivec3(int all);
        public extern ivec3(ivec2 xy, int z);
        public extern ivec3(int x, ivec2 yz);
        public extern ivec3(int x, int y, int z);

        public extern int x { get; set; }
        public extern int y { get; set; }
        public extern int z { get; set; }

        public extern int r { get; set; }
        public extern int g { get; set; }
        public extern int b { get; set; }
        public extern int a { get; set; }

        public extern int s { get; set; }
        public extern int t { get; set; }
        public extern int p { get; set; }

        public extern int this[int item]{ get; set; }

        public extern static ivec3 operator +(ivec3 left, ivec3 right);
        public extern static ivec3 operator -(ivec3 left, ivec3 right);
        public extern static ivec3 operator *(ivec3 left, ivec3 right);
        public extern static ivec3 operator /(ivec3 left, ivec3 right);
    }

    protected struct uivec3
    {
        public extern uivec3(uint all);
        public extern uivec3(uivec2 xy, uint z);
        public extern uivec3(uint x, uivec2 yz);
        public extern uivec3(uint x, uint y, uint z);

        public extern uint x { get; set; }
        public extern uint y { get; set; }
        public extern uint z { get; set; }

        public extern uint r { get; set; }
        public extern uint g { get; set; }
        public extern uint b { get; set; }

        public extern uint s { get; set; }
        public extern uint t { get; set; }
        public extern uint p { get; set; }

        public extern uint this[int item]{ get; set; }

        public extern static uivec3 operator +(uivec3 left, uivec3 right);
        public extern static uivec3 operator -(uivec3 left, uivec3 right);
        public extern static uivec3 operator *(uivec3 left, uivec3 right);
        public extern static uivec3 operator /(uivec3 left, uivec3 right);
    }

    protected struct vec3
    {
        public extern vec3(float all);
        public extern vec3(vec2 xy, float z);
        public extern vec3(float x, vec2 yz);
        public extern vec3(float x, float y, float z);

        public extern float x { get; set; }
        public extern float y { get; set; }
        public extern float z { get; set; }

        public extern float r { get; set; }
        public extern float g { get; set; }
        public extern float b { get; set; }

        public extern float s { get; set; }
        public extern float t { get; set; }
        public extern float p { get; set; }

        public extern float this[int item]{ get; set; }

        public extern static vec3 operator +(vec3 left, vec3 right);
        public extern static vec3 operator -(vec3 left, vec3 right);
        public extern static vec3 operator *(vec3 left, vec3 right);
        public extern static vec3 operator /(vec3 left, vec3 right);
    }

    protected struct dvec3
    {
        public extern dvec3(double all);
        public extern dvec3(dvec2 xy, double z);
        public extern dvec3(double x, dvec2 yz);
        public extern dvec3(double x, double y, double z);

        public extern double x { get; set; }
        public extern double y { get; set; }
        public extern double z { get; set; }

        public extern double r { get; set; }
        public extern double g { get; set; }
        public extern double b { get; set; }

        public extern double s { get; set; }
        public extern double t { get; set; }
        public extern double p { get; set; }

        public extern double this[int item]{ get; set; }

        public extern static dvec3 operator +(dvec3 left, dvec3 right);
        public extern static dvec3 operator -(dvec3 left, dvec3 right);
        public extern static dvec3 operator *(dvec3 left, dvec3 right);
        public extern static dvec3 operator /(dvec3 left, dvec3 right);
    }

    protected struct bvec4
    {
        public extern bvec4(bool all);
        public extern bvec4(bvec3 xyz, bool w);
        public extern bvec4(bool x, bvec3 yzw);
        public extern bvec4(bvec2 xy, bvec2 zw);
        public extern bvec4(bvec2 xy, bool z, bool w);
        public extern bvec4(bool x, bvec2 zw, bool y);
        public extern bvec4(bool x, bool y, bvec2 zw);
        public extern bvec4(bool x, bool y, bool z, bool w);

        public extern bool x { get; set; }
        public extern bool y { get; set; }
        public extern bool z { get; set; }
        public extern bool w { get; set; }

        public extern bool r { get; set; }
        public extern bool g { get; set; }
        public extern bool b { get; set; }
        public extern bool a { get; set; }

        public extern bool s { get; set; }
        public extern bool t { get; set; }
        public extern bool p { get; set; }
        public extern bool q { get; set; }

        public extern bool this[int item]{ get; set; }

        public extern static bvec4 operator +(bvec4 left, bvec4 right);
        public extern static bvec4 operator -(bvec4 left, bvec4 right);
        public extern static bvec4 operator *(bvec4 left, bvec4 right);
        public extern static bvec4 operator /(bvec4 left, bvec4 right);
    }

    protected struct ivec4
    {
        public extern ivec4(int all);
        public extern ivec4(ivec3 xyz, int w);
        public extern ivec4(int x, ivec3 yzw);
        public extern ivec4(ivec2 xy, ivec2 zw);
        public extern ivec4(ivec2 xy, int z, int w);
        public extern ivec4(int x, ivec2 zw, int y);
        public extern ivec4(int x, int y, ivec2 zw);
        public extern ivec4(int x, int y, int z, int w);

        public extern int x { get; set; }
        public extern int y { get; set; }
        public extern int z { get; set; }
        public extern int w { get; set; }

        public extern int r { get; set; }
        public extern int g { get; set; }
        public extern int b { get; set; }
        public extern int a { get; set; }

        public extern int s { get; set; }
        public extern int t { get; set; }
        public extern int p { get; set; }
        public extern int q { get; set; }

        public extern int this[int item]{ get; set; }

        public extern static ivec4 operator +(ivec4 left, ivec4 right);
        public extern static ivec4 operator -(ivec4 left, ivec4 right);
        public extern static ivec4 operator *(ivec4 left, ivec4 right);
        public extern static ivec4 operator /(ivec4 left, ivec4 right);
    }

    protected struct uivec4
    {
        public extern uivec4(uint all);
        public extern uivec4(uivec3 xyz, uint w);
        public extern uivec4(uint x, uivec3 yzw);
        public extern uivec4(uivec2 xy, uivec2 zw);
        public extern uivec4(uivec2 xy, uint z, uint w);
        public extern uivec4(uint x, uivec2 zw, uint y);
        public extern uivec4(uint x, uint y, uivec2 zw);
        public extern uivec4(uint x, uint y, uint z, uint w);

        public extern uint x { get; set; }
        public extern uint y { get; set; }
        public extern uint z { get; set; }
        public extern uint w { get; set; }

        public extern uint r { get; set; }
        public extern uint g { get; set; }
        public extern uint b { get; set; }
        public extern uint a { get; set; }

        public extern uint s { get; set; }
        public extern uint t { get; set; }
        public extern uint p { get; set; }
        public extern uint q { get; set; }

        public extern uint this[int item]{ get; set; }

        public extern static uivec4 operator +(uivec4 left, uivec4 right);
        public extern static uivec4 operator -(uivec4 left, uivec4 right);
        public extern static uivec4 operator *(uivec4 left, uivec4 right);
        public extern static uivec4 operator /(uivec4 left, uivec4 right);
    }

    protected struct vec4
    {
        public extern vec4(float all);
        public extern vec4(vec3 xyz, float w);
        public extern vec4(float x, vec3 yzw);
        public extern vec4(vec2 xy, vec2 zw);
        public extern vec4(vec2 xy, float z, float w);
        public extern vec4(float x, vec2 zw, float y);
        public extern vec4(float x, float y, vec2 zw);
        public extern vec4(float x, float y, float z, float w);

        public extern float x { get; set; }
        public extern float y { get; set; }
        public extern float z { get; set; }
        public extern float w { get; set; }

        public extern float r { get; set; }
        public extern float g { get; set; }
        public extern float b { get; set; }
        public extern float a { get; set; }

        public extern float s { get; set; }
        public extern float t { get; set; }
        public extern float p { get; set; }
        public extern float q { get; set; }

        public extern float this[int item]{ get; set; }

        public extern static vec4 operator +(vec4 left, vec4 right);
        public extern static vec4 operator -(vec4 left, vec4 right);
        public extern static vec4 operator *(vec4 left, vec4 right);
        public extern static vec4 operator /(vec4 left, vec4 right);
    }

    protected struct dvec4
    {
        public extern dvec4(double all);
        public extern dvec4(dvec3 xyz, double w);
        public extern dvec4(double x, dvec3 yzw);
        public extern dvec4(dvec2 xy, dvec2 zw);
        public extern dvec4(dvec2 xy, double z, double w);
        public extern dvec4(double x, dvec2 zw, double y);
        public extern dvec4(double x, double y, dvec2 zw);
        public extern dvec4(double x, double y, double z, double w);

        public extern double x { get; set; }
        public extern double y { get; set; }
        public extern double z { get; set; }
        public extern double w { get; set; }

        public extern double r { get; set; }
        public extern double g { get; set; }
        public extern double b { get; set; }
        public extern double a { get; set; }

        public extern double s { get; set; }
        public extern double t { get; set; }
        public extern double p { get; set; }
        public extern double q { get; set; }

        public extern double this[int item]{ get; set; }

        public extern static dvec4 operator +(dvec4 left, dvec4 right);
        public extern static dvec4 operator -(dvec4 left, dvec4 right);
        public extern static dvec4 operator *(dvec4 left, dvec4 right);
        public extern static dvec4 operator /(dvec4 left, dvec4 right);
    }
}