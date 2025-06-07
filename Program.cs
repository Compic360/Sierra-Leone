// See https://aka.ms/new-console-template for more information


// TECH


using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics;
using System.Globalization;
using NAudio.Wave;
using System;
using System.Reflection.Emit;
using System.Diagnostics;
using NAudio.CoreAudioApi;

// HEALTH, CASH, MORE


int HP = 100;
int CR = 0;
int XP = 0;
int LV = 0;


void AddXP(int amount)
{
    XP += amount;

    while (XP >= 100)
    {
        XP -= 100;
        LV ++;
        Console.WriteLine($"Level up! New level: {LV}");
        ADDCR(150);
        ADDHP(100);
    }
}

void ADDCR(int amount)
{
    CR += amount;
}

void ADDHP(int amount)
{
    HP += amount;
}


bool HasBurger = false;
bool HasSword = false;
bool HasArmor = false;
bool HasCrystal = false;
bool HasMedal = false;
bool HasCC = false;

void OpenUrl(string url)
{
    try
    {
        // For .NET Core and .NET 5/6/7/8 compatibility
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        };
        Process.Start(psi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Failed to open URL: " + ex.Message);
    }
}

// CHEAT VOID

void cheats ()
{
    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("");
 string chmen1 = "  ,ad8888ba,   88        88  88888888888         db    888888888888  ad88888ba   ";
 Console.SetCursorPosition((Console.WindowWidth - chmen1.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen1);
 string chmen2 = " d8\"'    `\"8b  88        88  88                 d88b        88      d8\"     \"8b  ";
 Console.SetCursorPosition((Console.WindowWidth - chmen2.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen2);
 string chmen3 = "d8'            88        88  88                d8'`8b       88      Y8,          ";
 Console.SetCursorPosition((Console.WindowWidth - chmen3.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen3);
 string chmen4 = "88             88aaaaaaaa88  88aaaaa          d8'  `8b      88      `Y8aaaaa,    ";
 Console.SetCursorPosition((Console.WindowWidth - chmen4.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen4);
 string chmen5 = "88             88\"\"\"\"\"\"\"\"88  88\"\"\"\"\"         d8YaaaaY8b     88        `\"\"\"\"\"8b,  ";
 Console.SetCursorPosition((Console.WindowWidth - chmen5.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen5);
 string chmen6 = "Y8,            88        88  88             d8\"\"\"\"\"\"\"\"8b    88              `8b  ";
 Console.SetCursorPosition((Console.WindowWidth - chmen6.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen6);
 string chmen7 = " Y8a.    .a8P  88        88  88            d8'        `8b   88      Y8a     a8P  ";
 Console.SetCursorPosition((Console.WindowWidth - chmen7.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen7);
 string chmen8 = "  `\"Y8888Y\"'   88        88  88888888888  d8'          `8b  88       \"Y88888P\"   ";
 Console.SetCursorPosition((Console.WindowWidth - chmen8.Length) / 2, Console.CursorTop);
 Console.WriteLine(chmen8);
 Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
 Console.WriteLine("");
 Console.WriteLine("Vlož cheat kód");

 switch (Console.ReadLine())
    {
        case "/TGM":
            GodMode();
            chap1();
            break;
        case "/SKIP1":
            SKIP1();
            break;
        case "/SKIP2":
            SKIP2();
            break;
        case "/SKIP3":
            SKIP3();
            break;
        case "/SKIP4":
            SKIP4();
            break;
        case "/SKIP5":
            SKIP5();
            break;
        case "/SKIP6":
            SKIP6();
            break;
        case "/SKIP7":
            SKIP7();
            break;
        case "/$":
            Rich();
            chap1();
            break;
        case "/$$$":
            XRich();
            chap1();
            break;
        case "/END":
            SKIP8();
            break;
        case "//JOB":
            Console.WriteLine("Get a job nigga");
            OpenUrl("https://eforms.com/images/2018/03/Employment-Job-Application-791x1024.png");
            break;
        case "//WEB":
            OpenUrl("https://cxomxpixc.eu/");
            break;


    }

}

// VOIDS: CHEATS


void GodMode ()
{
    int playerHealth = 2147483647;
    Console.WriteLine("Kód použit! Máte teď nekonečno životů.");
    Thread.Sleep(3000);
}

void Rich()
{
    ADDCR(2147483647);
    Console.WriteLine("Kód použit! Jsi rich!");
    Thread.Sleep(3000);
}

void XRich()
{
    ADDCR(2147483647);
    bool HasBurger = true;
    bool HasSword = true;
    bool HasArmor = true;
    bool HasCrystal = true;
    bool HasMedal = true;
    bool HasCC = true;
    Console.WriteLine("Kód použit! Jsi MEGA rich$$$!!!");
    Thread.Sleep(3000);
}

void SKIP1()
{
    Console.WriteLine("Kód použit! Přeskakujeme 1. kapitolu");  //
    Thread.Sleep(3000);
    chap2();
}

void SKIP2()
{
    Console.WriteLine("Kód použit! Přeskakujeme 2. kapitolu"); //
    Thread.Sleep(3000);
    chap3();
}

void SKIP3()
{
    Console.WriteLine("Kód použit! Přeskakujeme 3. kapitolu"); //
    Thread.Sleep(3000);
    chap4();
}

void SKIP4()
{
    Console.WriteLine("Kód použit! Přeskakujeme 4. kapitolu"); //
    Thread.Sleep(3000);
    chap5();
}

void SKIP5()
{
    Console.WriteLine("Kód použit! Přeskakujeme 5. kapitolu"); //
    Thread.Sleep(3000);
    chap6();
}

void SKIP6()
{
    Console.WriteLine("Kód použit! Přeskakujeme 6. kapitolu"); //
    Thread.Sleep(3000);
    chap7();
}

void SKIP7()
{
    Console.WriteLine("Kód použit! Přeskakujeme 7. kapitolu"); //
    Thread.Sleep(3000);
    chap8();
}

void SKIP8()
{
    Console.WriteLine("Kód použit! Jdeme na endgame!");       //
    Thread.Sleep(3000);
    END();
}


// TITLE


Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
string title1 = "______   __    _   _____ _                       _                           ";
Console.SetCursorPosition((Console.WindowWidth - title1.Length) / 2, Console.CursorTop);
Console.WriteLine(title1);
string title2 = "| ___ \\ /_/   | | /  ___(_)                     | |                          ";
Console.SetCursorPosition((Console.WindowWidth - title2.Length) / 2, Console.CursorTop);
Console.WriteLine(title2);
string title3 = "| |_/ /_ _  __| | \\ `--. _  ___ _ __ _ __ __ _  | |     ___  ___  _ __   ___ ";
Console.SetCursorPosition((Console.WindowWidth - title3.Length) / 2, Console.CursorTop);
Console.WriteLine(title3);
string title4 = "|  __/ _` |/ _` |  `--. \\ |/ _ \\ '__| '__/ _` | | |    / _ \\/ _ \\| '_ \\ / _ \\";
Console.SetCursorPosition((Console.WindowWidth - title4.Length) / 2, Console.CursorTop);
Console.WriteLine(title4);
string title5 = "| | | (_| | (_| | /\\__/ / |  __/ |  | | | (_| | | |___|  __/ (_) | | | |  __/";
Console.SetCursorPosition((Console.WindowWidth - title5.Length) / 2, Console.CursorTop);
Console.WriteLine(title5);
string title6 = "\\_|  \\__,_|\\__,_| \\____/|_|\\___|_|  |_|  \\__,_| \\_____/\\___|\\___/|_| |_|\\___|";
Console.SetCursorPosition((Console.WindowWidth - title6.Length) / 2, Console.CursorTop);
Console.WriteLine(title6);
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine();

// MENU "BUTTONS"


string ass1 = "[1] START     ";
string ass2 = "[2] CREDITS   ";
string ass3 = "[3] CHEAT MENU";
string ass4 = "[4] EXIT GAME ";

Console.SetCursorPosition((Console.WindowWidth - ass1.Length) / 2, Console.CursorTop);
Console.WriteLine(ass1);
Console.SetCursorPosition((Console.WindowWidth - ass2.Length) / 2, Console.CursorTop);
Console.WriteLine(ass2);
Console.SetCursorPosition((Console.WindowWidth - ass3.Length) / 2, Console.CursorTop);
Console.WriteLine(ass3);
Console.SetCursorPosition((Console.WindowWidth - ass4.Length) / 2, Console.CursorTop);
Console.WriteLine(ass4);
Console.WriteLine("");



ConsoleKeyInfo key = Console.ReadKey(true); 

switch (key.Key)
{
    case ConsoleKey.D1:       // PASS
    case ConsoleKey.NumPad1:
        Console.WriteLine("Ready.. Player.. One..");
        chap1();
        return;

    case ConsoleKey.D2:       // CREDITS
    case ConsoleKey.NumPad2:
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string cred1 = " _____ ______ ___________ _____ _____ _____ ";
            Console.SetCursorPosition((Console.WindowWidth - cred1.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred1);
            string cred2 = "/  __ \\| ___ \\  ___|  _  \\_   _|_   _/  ___|";
            Console.SetCursorPosition((Console.WindowWidth - cred2.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred2);
            string cred3 = "| /  \\/| |_/ / |__ | | | | | |   | | \\ `--. ";
            Console.SetCursorPosition((Console.WindowWidth - cred3.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred3);
            string cred4 = "| |    |    /|  __|| | | | | |   | |  `--. \\";
            Console.SetCursorPosition((Console.WindowWidth - cred4.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred4);
            string cred5 = "| \\__/\\| |\\ \\| |___| |/ / _| |_  | | /\\__/ /";
            Console.SetCursorPosition((Console.WindowWidth - cred5.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred5);
            string cred6 = " \\____/\\_| \\_\\____/|___/  \\___/  \\_/ \\____/ ";
            Console.SetCursorPosition((Console.WindowWidth - cred6.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred6);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            string cred7 = "Tuhle hru jsem udělal v Visual Studio 2022, programovací jazyk C#. Slava kazachstánu!!!";
            Console.SetCursorPosition((Console.WindowWidth - cred7.Length) / 2, Console.CursorTop);
            Console.WriteLine(cred7);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            return;
        }

    case ConsoleKey.D3:      // CHEATS
    case ConsoleKey.NumPad3:
        Console.Clear();
        cheats();
        return;

    case ConsoleKey.D4:
    case ConsoleKey.NumPad4: // EXIT
        break;
}


//CHAPTERS


void chap1 ()
{
    Thread.Sleep(3000);
}

void chap2()
{

}

void chap3()
{

}

void chap4()
{

}

void chap5()
{

}

void chap6()
{

}

void chap7()
{

}

void chap8()
{

}

void END ()
{

}


//BOSSES

void BOSS1()
{
    Thread.Sleep(3000);
}

void BOSS2()
{

}

void BOSS3()
{

}

void BOSS4()
{

}

void BOSS5()
{

}

void BOSS6()
{

}

void BOSS7()
{

}

void BOSS8()
{

}


/*
Go, go, go, go
Head so good, she a honor roll, she ride the dick like a carnival
I done did the impossible
Go, go, go, go
Head so good, she a honor roll, she ride the dick like a carnival
I done did the impossible
Ah, ah, ah (schyeah)
Way too rich to drive a Rove', made a milli' off the stove
She like to put it in her nose, pretty bitch with white toes
I done put on all the bros, I done fucked her in the Rolls
I done pulled up in the Ghost, I done reached all my goals
Yeah-yeah, pull up with Yeezy and Dolla $ign, I'm all about bidness, I'm mindin' mine
Pull up in the trenches like Columbine, pull up with the rocket like NumbaNine
I don't want your hos, young nigga reach all the goals
Let her suck the dick, said she was a pro, if she scrape her teeth, I'ma tell her to go
Go, go, go, go
Head so good, she a honor roll, she'll ride the dick like carnival
I done did the impossible
Go, go, go, go
Head so good, she a honor roll, she'll ride the dick like carnival
I done did the impossible (Dolla $ign)
She ride it like Six Flags, we turn up to the max
I whop her from the back, I gave that bitch a cramp
They love me out in France, in the hood, I'm good, I'm stamped
Every day, I dress all black, for a show, 900 racks
Middle East call, double that, on my neck a bubble bath
On my wrist new Cadillac, cut her off, don't want her back
Lil' bitch, I'm a superstar, these hos wanna fuck my car
My dawg put a nigga in park, gotta watch out for the narcs, ay
This that Game of Thrones, Yeezy, not the clones
Elon, where my rocket ship? It's time to go home
They served us the porn since the day we was born
Anybody pissed off, gotta make 'em drink the urine
Now I'm Ye-Kelly, bitch, now I'm Bill Cosby, bitch
Now, I'm Puff Daddy rich, that's Me Too me rich
Why she say she sucked my dick? Then she say she ain't sucked my dick?
She gon' take it up the ass like a ventriloquist
I mean since Taylor Swift, since I had the Rollie on the wrist
I'm the new Jesus, bitch, I turn water to Cris'
This for what they did to Chris, they can't do shit with this
Got my kids in a fake school, we ain't
Go, go, go, go
Head so good, she a honor roll, she'll ride the dick like carnival (schyeah)
I done did the impossible (schyeah)
Go, go, go, go
Head so good, she a honor roll, she'll ride the dick like carnival
I done did the impossible
She ride the dick like a carnival
Bend her over, havin' flashbacks, she gon' eat me up like a carnivore
It's the way I pop my shit, the hos not ready, I'm goin' barnacles
Movin', I feel like I'm Jason, can't get arrested, I make 'em stumble
She want a private section, roll off them X's when I'm on Melrose
She tatted my name on her titties, yeah, you can bust it, but it's a borrow
Hol' up, sittin' back, countin' up dubs, I was raised in the borough
She wanna taste it, checkin' the swag today, ho, come back tomorrow
If you know what I know, hide your ho, just off the facts that we havin' 'em hunchos
Runnin' around in the lobby, I know that they tired of me havin' like ten hos
She need some cresidentials just to be presidential, hol' up, hol' up
I'm 'bout to buy her some dentures, make that ho eat me for dinner, whoa-whoa
Pain all in my eyes, I can't see, uh
I'm 'bout to jump out my body, I'm ready to leap, uh
I'm 'bout to nut on her body and tell the ho, "Leave", 'kay
50 mil' stuffed in the bag, tell the whole gang eat, uh
It's Ye and Barti, tell me who fuckin' with we?
I'm hot like Tha Carter, I'm feelin' that ho in my sleep
Dollar signs all in my dreams, I don't never see Z's, whoa, whoa-whoa
The swag cover my body like it's a disease, whoa, whoa-whoa
Whoa, whoa, whoa
Whoa, whoa, whoa
Go, go, go, go
Head so good, she a honor roll, she ride the dick like a carnival
I done did the impossible
Go, go, go, go
Head so good, she a honor roll, she ride the dick like a carnival
I done did the impossible
Go, go, go, go
Go, go, go, go
Go, go, go, go
Go, go, go, go
*/

