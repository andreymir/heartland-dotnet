﻿namespace SecureSubmit.Infrastructure
{
    public enum HpsExceptionCodes
    {
        /* General Codes */
        AuthenticationError,
        InvalidConfiguration,
        InvalidArgument,

        /* Input Codes */
        InvalidAmount,
        MissingCurrency,
        InvalidCurrency,
        InvalidDate,

        /* Gateway Codes */
        UnknownGatewayError,
        InvalidOriginalTransaction,
        NoOpenBatch,
        InvalidCpcData,
        InvalidCardData,
        InvalidNumber,
        GatewayTimeout,
        UnexpectedGatewayResponse,
        GatewayTimeoutReversalError,

        /* Credit Issuer Codes */
        IncorrectNumber,
        ExpiredCard,
        InvalidPin,
        PinRetriesExceeded,
        InvalidExpiry,
        PinVerification,
        IssuerTimeout,
        IncorrectCvc,
        CardDeclined,
        ProcessingError,
        IssuerTimeoutReversalError,
        UnknownIssuerError,

        /* Gift Issuer Codes */
        CardAlreadyActivated,

        MissingCheckName
    }

    public enum HpsTransactionType
    {
        Authorize,
        Capture,
        Charge,
        Refund,
        Reverse,
        Verify,
        List,
        Get,
        Void,
        SecurityError,
        BatchClose
    }

    public enum HpsGiftCardAliasAction
    {
        Delete,
        Add,
        Create
    }

    public enum HpsTrackDataMethod
    {
        Swipe,
        Proximity
    }
}
