namespace SOLID.Layouts
{
    class XmlLayout : ILayout
    {
        public string Template => "<log>\n" +
            "\t<date>{0}</date>\n" +
            "\t<level>{1}</level>\n" +
            "\t<message>{2}</message>\n" +
            "</log>";
    }
}
