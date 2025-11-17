string? nickname = null;

int NicknameLength()
{
    return nickname?.Length ?? 0;
}

Console.Write("Nickname: ");
nickname = Console.ReadLine();

int nicknameLength = NicknameLength();

if (nicknameLength == 0)
{
    Console.WriteLine("Никнейм пустой.");
    return;
}

Console.WriteLine($"Никнейм: {nickname}, Длина: {nicknameLength}");
