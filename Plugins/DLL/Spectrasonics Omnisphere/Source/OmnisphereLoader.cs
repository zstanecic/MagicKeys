using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnisphereLoader()
{
MouseClick("Left", Coords.X+20, Coords.Y+20, 1, 0, 0, 10);
while(
ImgSearch("Reg", true)[0] == 0 &&
ImgSearch("Logo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch("Reg", true)[0] == 1)
{
VUILoader("OmnisphereReg");
}
else
{
AudoSelect();
}
}

}
}