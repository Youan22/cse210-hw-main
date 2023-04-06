using System;
using System.Globalization;

public class Entry
{
    private string prompt;
    private string response;
    private DateTime date;
    private string v;

    public Entry(string prompt, string response, DateTime date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public Entry(string prompt, string response, string v)
    {
        this.prompt = prompt;
        this.response = response;
        this.v = v;
    }

    public string Prompt
    {
        get { return prompt; }
        set { prompt = value; }
    }

    public string Response
    {
        get { return response; }
        set { response = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }


    public override string ToString()
    {
        return $"Prompt: {prompt}\nResponse: {response}\nDate: {date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}\n";
    }

internal ReadOnlySpan<char> ToCSVString()
{
        string Text = null;
        string[] fields = { date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), Text };
    return string.Join(",", fields).AsSpan();
}

}
