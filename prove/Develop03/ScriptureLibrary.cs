using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Ref reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
            throw new InvalidOperationException("No scriptures available in the library.");

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}