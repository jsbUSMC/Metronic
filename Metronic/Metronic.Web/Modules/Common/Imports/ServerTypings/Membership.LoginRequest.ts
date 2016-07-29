namespace Metronic.Membership {
    export interface LoginRequest extends Serenity.ServiceRequest {
        Username?: string
        Password?: string
    }
}

