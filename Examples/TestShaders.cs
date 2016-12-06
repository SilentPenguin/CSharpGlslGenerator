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