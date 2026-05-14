namespace Shelly_CLI.Commands.Standard;

// TODO: Move to PackageManager #771
public record LocalPackageDto(
    string Name,
    long Size
);
