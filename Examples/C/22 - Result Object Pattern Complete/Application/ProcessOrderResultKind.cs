namespace CleanCode.Application;

enum ProcessOrderResultKind
{
    Success = 0,
    NotProcessable = 1,
    HasTooManyItems = 2,
    NotReadyForProcessing = 3
}
