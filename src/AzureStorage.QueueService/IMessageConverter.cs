﻿namespace AzureStorage.QueueService;

public interface IMessageConverter
{
    TOutput? Convert<TOutput>(BinaryData input);

    TOutput? Convert<TOutput>(string input);

    BinaryData Convert<TInput>(TInput input);
}