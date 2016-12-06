/*

#version 330
in vec3 in_vertex;
in vec3 in_vertex_color;
out vec4 vert_color;
uniform mat4 in_transform;
void main ()
{
    mat4 world = mat4(0.25);
    world[3] = vec4(0, 0, 0, 1);
    vec4 pos = world * in_transform * vec4(in_vertex, 1.0);
    gl_Position = pos;
    vert_color = vec4(in_vertex_color, 1.0);
}

#version 330
in vec4 vert_color;
uniform vec4 in_color;
out vec4 out_color;
void main()
{
    out_color = vert_color * in_color;
}

 */

public class ExampleVertexShader : VertexShader
{
	[Uniform] readonly mat4 in_transform;
	[In] vec3 in_vertex;
	[In] vec3 in_color;
	[Out] vec4 vert_color;

	void main()
	{
		var world = new mat4(0.25f);
		world[3] = new vec4(0, 0, 0, 1);
		gl_Position = world * inverse(in_transform) * new vec4(in_vertex, 1);
		vert_color = new vec4(in_color, 1);
	}
}

public class ExampleFragmentShader : FragmentShader
{
	[Uniform] readonly vec4 in_color;
	[In] vec4 vert_color;
	[Out] vec4 out_color;

	void main()
	{
		out_color = vert_color * in_color;
	}
}