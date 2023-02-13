
//napisz w Program.sc kod, w którym:
/// zadeklarujesz zmienną z imieniem
/// zadeklarujesz zmienną z płcią
/// zadeklarujesz zmienną z wiekiem
/// - zweryfikujesz dane i wyświetlisz
/// jeden z komunikatów:
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa lat 33"
/// (3): "Niepełnoletni męższczyzna"
/// ----------------------------
/// 
var name = "Ewa";
var age = 33;
int ageW = 20;
var sexW = "Woman";
var age18 = 18;
var sexM = "Man";

if (sexW == "Woman" && ageW < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Ktoś przed lub po 30 latach");
}
if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else
{
    Console.WriteLine("Ewa w innym wieku");
}
if (sexM == "Man" && age18 <= 18)
{
    Console.WriteLine("Męższczyzna niepełnoletni");
}
else
{
    Console.WriteLine("Męższczyzna pełnoletni");
}