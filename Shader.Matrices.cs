#pragma warning disable

public abstract partial class Shader
{
    protected struct mat2
    {
        public extern mat2(float diag);
        public extern mat2(mat3 matrix);
        public extern mat2(mat4 matrix);
        public extern mat2(vec2 col0, vec2 col1);
        public extern mat2(
            float x0y0, float x0y1,
            float x1y0, float x1y1
        );
        
        public extern vec2 this[int column]{ get; set; }

        public extern static mat2 operator +(mat2 left, mat2 right);
        public extern static mat2 operator -(mat2 left, mat2 right);
        public extern static mat2 operator *(mat2 left, mat2 right);
        public extern static mat2 operator /(mat2 left, mat2 right);

        public extern static vec2 operator *(mat2 left, vec2 right);
        public extern static vec2 operator *(vec2 left, mat2 right);
    }

    protected struct mat3
    {
        public extern mat3(float diag);
        public extern mat3(mat2 matrix);
        public extern mat3(mat4 matrix);
        public extern mat3(vec3 col0, vec3 col1, vec3 col2);
        public extern mat3(
            float x0y0, float x0y1, float x0y2,
            float x1y0, float x1y1, float x1y2,
            float x2y0, float x2y1, float x2y2
        );
        
        public extern vec3 this[int column]{ get; set; }

        public extern static mat3 operator +(mat3 left, mat3 right);
        public extern static mat3 operator -(mat3 left, mat3 right);
        public extern static mat3 operator *(mat3 left, mat3 right);
        public extern static mat3 operator /(mat3 left, mat3 right);

        public extern static vec3 operator *(mat3 left, vec3 right);
        public extern static vec3 operator *(vec3 left, mat3 right);
    }

    protected struct mat4
    {
        public extern mat4(float diag);
        public extern mat4(mat2 matrix);
        public extern mat4(mat3 matrix);
        public extern mat4(vec4 col0, vec4 col1, vec4 col2, vec4 col3);

        public extern mat4(
            float x0y0, float x0y1, float x0y2, float x0y3,
            float x1y0, float x1y1, float x1y2, float x1y3,
            float x2y0, float x2y1, float x2y2, float x2y3,
            float x3y0, float x3y1, float x3y2, float x3y3
        );
        
        public extern vec4 this[int column]{ get; set; }
        
        public extern static mat4 operator +(mat4 left, mat4 right);
        public extern static mat4 operator -(mat4 left, mat4 right);
        public extern static mat4 operator *(mat4 left, mat4 right);
        public extern static mat4 operator /(mat4 left, mat4 right);

        public extern static vec4 operator *(mat4 left, vec4 right);
        public extern static vec4 operator *(vec4 left, mat4 right);
    }

    protected struct mat2x3
    {

    }

    protected struct mat2x4
    {
        
    }

    protected struct mat3x2
    {
        
    }

    protected struct mat3x4
    {
        
    }

    protected struct mat4x2
    {
        
    }

    protected struct mat4x3
    {
        
    }
}

#pragma warning restore