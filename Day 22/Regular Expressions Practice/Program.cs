using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== REGEX TRAINING EXAM PRACTICE =====");
            Console.WriteLine("1  - Product Key Basic");
            Console.WriteLine("2  - Product Key With Hyphen");
            Console.WriteLine("3  - Advanced License Code");
            Console.WriteLine("4  - Serial Number");
            Console.WriteLine("5  - Corporate Password");
            Console.WriteLine("6  - Strong Password Advanced");
            Console.WriteLine("7  - Banking PIN Hybrid");
            Console.WriteLine("8  - Employee ID");
            Console.WriteLine("9  - Ticket Number");
            Console.WriteLine("10 - Custom Product Key (16 char)");
            Console.WriteLine("0  - Exit");

            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 0) break;

            Console.Write("Enter input: ");
            string input = Console.ReadLine()!;

            bool result = false;

            switch (choice)
            {
                case 1: result = ProductKeyBasic(input); break;
                case 2: result = ProductKeyHyphen(input); break;
                case 3: result = LicenseAdvanced(input); break;
                case 4: result = SerialNumber(input); break;
                case 5: result = CorporatePassword(input); break;
                case 6: result = StrongPasswordAdvanced(input); break;
                case 7: result = BankingPinHybrid(input); break;
                case 8: result = EmployeeId(input); break;
                case 9: result = TicketNumber(input); break;
                case 10: result = CustomProductKey(input); break;
            }

            Console.WriteLine(result ? "Valid" : "Invalid");
        }
    }

    // ================= PRODUCT KEY SECTION =================

    static bool ProductKeyBasic(string input)
    {
        // Rules:
        // - Exactly 8 characters
        // - Start with capital letter
        // - End with digit
        // - Only letters and digits allowed

        string pattern = @"^[A-Z][A-Za-z0-9]{6}[0-9]$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool ProductKeyHyphen(string input)
    {
        // Rules:
        // Format: XXXX-XXXX
        // X = uppercase letter or digit
        // First char must be uppercase
        // Last char must be digit

        string pattern = @"^[A-Z][A-Z0-9]{3}\-[A-Z0-9]{3}[0-9]$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool LicenseAdvanced(string input)
    {
        // Rules:
        // 4 uppercase letters
        // Hyphen
        // 4 digits
        // Must contain at least one vowel
        // No consecutive identical letters

        string pattern = @"^(?=.*[AEIOU])(?!.*([A-Z])\1)[A-Z]{4}-[0-9]{4}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool SerialNumber(string input)
    {
        // Rules:
        // 12 characters total
        // First 2 uppercase letters
        // Next 4 digits
        // Last 6 alphanumeric
        // Must contain at least 2 digits overall

        string pattern = @"^(?=(?:.*\d){2})[A-Z]{2}\d{4}[A-Za-z0-9]{6}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    // ================= PASSWORD SECTION =================

    static bool CorporatePassword(string input)
    {
        // Rules:
        // 10–20 characters
        // At least 1 uppercase
        // At least 1 lowercase
        // At least 1 digit
        // At least 1 special (!@#$%^&*)
        // Cannot start with digit
        // Cannot end with special

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*])(?!\d)[A-za-z0-9!@#$%^&*]{9,18}(?<![!@#$%^&*])$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool StrongPasswordAdvanced(string input)
    {
        // Rules:
        // 12–18 characters
        // At least 2 digits
        // At least 2 uppercase
        // At least 1 special
        // No whitespace allowed

        string pattern = @"^(?=(?:.*\d){2})(?=(?:.*[A-Z]){2})(?=.*[!@#$%^&*])(?!.*\s).{12,18}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool BankingPinHybrid(string input)
    {
        // Rules:
        // Exactly 6 characters
        // 2 uppercase
        // 2 digits
        // 2 lowercase
        // No repeating consecutive characters

        string pattern = @"^(?!.*(.)\1)[A-Z]{2}\d{2}[a-z]{2}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    // ================= CORPORATE IDS =================

    static bool EmployeeId(string input)
    {
        // Rules:
        // Format: EMP-XXXX
        // X = digit
        // Cannot be EMP-0000

        string pattern = @"^EMP-(?!0000)\d{4}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool TicketNumber(string input)
    {
        // Rules:
        // Format: TKT-YYYY-NNN
        // YYYY starts with 20
        // NNN = 3 digits

        string pattern = @"^TKT-20\d{2}-\d{3}$"; // TODO
        return Regex.IsMatch(input, pattern);
    }

    static bool CustomProductKey(string input)
    {
        // Rules:
        // Format: XXXX-XXXX-XXXX-XXXX
        // First section: uppercase only
        // Second: digits only
        // Third: uppercase + digits
        // Fourth: must end with digit
        // At least 3 digits total

        string pattern = @"^(?=(?:.*\d){3})[A-Z]{4}-\d{4}-[A-Z\d]{4}-[A-Z0-9]{3}\d$"; // TODO
        return Regex.IsMatch(input, pattern);
    }
}
