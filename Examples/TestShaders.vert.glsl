#version 330
uniform mat4 in_transform;
in vec3 in_vertex;
in vec3 in_color;
out vec4 vert_color;
void main()
{
mat4 world = mat4(0.25f);
world[3] = vec4(0, 0, 0, 1);
gl_Position = world * inverse(in_transform) * vec4(in_vertex, 1);
vert_color = vec4(in_color, 1);
}
