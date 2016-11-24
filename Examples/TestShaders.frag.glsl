#version 330
uniform vec4 in_color;
in vec4 vert_color;
out vec4 out_color;
void main()
{
out_color = vert_color * in_color;
}
