namespace Payment.PayPal
{
    public static class PayPalConsts
    {
        public const string OrderIdPropertyName = "OrderId";

        public static class OrderStatus
        {
            public const string Created = "CREATED";

            public const string Saved = "SAVED";

            public const string Approved = "APPROVED";

            public const string Voided = "VOIDED";

            public const string Completed = "COMPLETED";

            public const string PlayerActionRequired = "PAYER_ACTION_REQUIRED";
        }

        public static class Environment
        {
            public const string Sandbox = "Sandbox";

            public const string Live = "Live";
        }
    }
}
