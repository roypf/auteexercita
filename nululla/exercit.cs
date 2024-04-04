// Ensure the file path is not null or empty
if (string.IsNullOrEmpty(filePath))
{
    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
}

try
{
    // Read all text asynchronously from the file at the given path
    string data = await File.ReadAllTextAsync(filePath).ConfigureAwait(false);
    // Process the data if needed
    // ...
}
catch (Exception ex)
{
    // Handle exceptions that may occur during file read operation
    Console.Error.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
