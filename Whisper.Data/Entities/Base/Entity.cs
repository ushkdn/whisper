﻿namespace Whisper.Data.Entities.Base;

public abstract record Entity : IEntity
{
    public int Id { get; init; }
}