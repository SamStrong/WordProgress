﻿namespace WordProgress.Domain.Commands
{
    public class RegisterWriter : BaseCommand
    {
        public string UserName { get; set; }
        public string Name { get; set; }
    }
}