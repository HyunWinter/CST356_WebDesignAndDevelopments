public static class BusinessRules
{
    public static bool isEndWithOITDomain(Student student) => 
        !student.email_address.EndsWith(oitDomain);
        
    public static string oitDomain = "@oit.edu";
}