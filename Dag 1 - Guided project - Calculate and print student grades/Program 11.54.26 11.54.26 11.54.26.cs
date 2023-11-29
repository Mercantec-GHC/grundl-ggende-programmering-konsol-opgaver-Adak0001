int currentAssignments = 5;

int sophia11 = 93;
int sophia12 = 87;
int sophia13 = 98;
int sophia14 = 95;
int sophia15 = 100;

int nicolas11 = 80;
int nicolas12 = 83;
int nicolas13 = 82;
int nicolas14 = 88;
int nicolas15 = 85;

int zahira11 = 84;
int zahira12 = 96;
int zahira13 = 73;
int zahira14 = 85;
int zahira15 = 79;

int jeong11 = 90;
int jeong12 = 96;
int jeong13 = 98;
int jeong14 = 100;
int jeong15 = 97;

int SophiaTotal = sophia11 + sophia12 + sophia13 + sophia14 + sophia15;
int NicolasTotal = nicolas11 + nicolas12 + nicolas13 + nicolas14 + nicolas15;
int ZahiraTotal = zahira11 + zahira12 + zahira13 + zahira14 + zahira15;
int JeongTotal = jeong11 + jeong12 + jeong13 + jeong14 + jeong15;

decimal SophiaScore = (decimal)SophiaTotal / currentAssignments;
decimal NicolasScore = (decimal)NicolasTotal / currentAssignments;
decimal ZahiraScore = (decimal)ZahiraTotal / currentAssignments;
decimal JeongScore = (decimal)JeongTotal / currentAssignments;

Console.WriteLine("Student\t\tTotal\tScore\tGrade\n");
Console.WriteLine("Sophia\t\t" + SophiaTotal + "\t" + SophiaScore + "\tA");
Console.WriteLine("Nicolas\t\t" + NicolasTotal + "\t" + NicolasScore + "\tB");
Console.WriteLine("Zahira\t\t" + ZahiraTotal + "\t" + ZahiraScore + "\tB");
Console.WriteLine("Jeong\t\t" + JeongTotal + "\t" + JeongScore + "\tA");
