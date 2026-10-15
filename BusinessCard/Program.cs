using Figgle.Fonts;

Console.ForegroundColor = ConsoleColor.DarkRed;

string ascii = """
          _       _                  _       _
         | |     | |                | |     | |
         | | ___ | |__  _ __        | | ___ | |__  _ __  ___  ___ _ __
     _   | |/ _ \| '_ \| '_ \   _   | |/ _ \| '_ \| '_ \/ __|/ _ \ '_ \
    | |__| | (_) | | | | | | | | |__| | (_) | | | | | | \__ \  __/ | | |
     \____/ \___/|_| |_|_| |_|  \____/ \___/|_| |_|_| |_|___/\___|_| |_|

    """;
Console.WriteLine(ascii);
Console.ResetColor();
Console.WriteLine("+-------------------------------+");
Console.Write("| ");
Console.WriteLine("Opleiding: Graduaat Programeren |");
Console.Write("| ");
Console.WriteLine("Kladgroep: 1PROe |");
Console.Write("| ");
Console.WriteLine("Leukste Olod: Weekend |");
Console.WriteLine("+-------------------------------+");






Console.ForegroundColor = ConsoleColor.Yellow;
string output = FiggleFonts.Speed.Render("Willem!");
Console.WriteLine(output);
Console.ResetColor();
