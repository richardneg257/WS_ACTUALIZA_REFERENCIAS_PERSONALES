namespace BCP.Framework
{
    public class Validation
    {
        public enum Responses
        {
            COMPLETED,
            ERROR,
            EXCEPTION,
            SESSION_EXPIRED
        };

        public enum ErrorMessages
        {
            Sql,
            Service,
            InvalidCurrency,
            InvalidEmail,
            InvalidAmount,
            InvalidMobile,
            FailedQrGenerated,
            DebitError,
            CreditError,
            CodeOtpUsed,
            CodeOtpInvalid,
            NotRegisteredQr,
            NotUpdatedQr,
            UnidentifiedQr,
            UnidentifiedBusiness,
            NotRegisteredNotificationAch,
            NotUpdatedNotificationAch,
            UnidentifiedNotificationAch,
            NotRegisteredNotificationEmail,
            NotUpdatedNotificationEmail,
            UnidentifiedNotificationEmail,
            NotRegisteredNotificationUrl,
            NotUpdatedNotificationUrl,
            UnidentifiedNotificationUrl,
            NotRegisteredNotificationService,
            NotUpdatedNotificationService,
            UnidentifiedNotificationService,
            WalletServiceError,
            ExpireDateInvalid,
            ComplementIdcInvalid
        }

        public static string Exception(Responses responses)
        {
            switch (responses)
            {
                case Responses.COMPLETED:
                    return "COMPLETADO";
                case Responses.EXCEPTION:
                    return "EXCEPCIÓN";
                case Responses.SESSION_EXPIRED:
                    return "SESION EXPIRADA";
                default:
                    return "HA OCURRIDO UN ERROR";
            }
        }

        public static string ErrorMessage(ErrorMessages message)
        {
            switch (message)
            {
                case ErrorMessages.Sql:
                    return "Ha ocurrido un error y puede que el servicio no este disponible temporalmente.";
                case ErrorMessages.Service:
                    return "Ha ocurrido un error en el servicio.";
                case ErrorMessages.InvalidAmount:
                    return "Monto no válido.";
                case ErrorMessages.InvalidCurrency:
                    return "Moneda no válida.";
                case ErrorMessages.InvalidEmail:
                    return "Correo no válido.";
                case ErrorMessages.InvalidMobile:
                    return "Celular no válido.";
                case ErrorMessages.FailedQrGenerated:
                    return "Algo ha ocurrido en generar Qr, una solicitud mal formada o ilegal.";
                case ErrorMessages.DebitError:
                    return "Error al debitar.";
                case ErrorMessages.CreditError:
                    return "Error al abonar.";
                case ErrorMessages.CodeOtpUsed:
                    return "Código OTP ya fue utilizado.";
                case ErrorMessages.CodeOtpInvalid:
                    return "Código OTP invalido.";
                case ErrorMessages.NotRegisteredQr:
                    return "Qr no registrado.";
                case ErrorMessages.NotUpdatedQr:
                    return "Qr no actualizado.";
                case ErrorMessages.UnidentifiedQr:
                    return "Qr no identificado.";
                case ErrorMessages.NotRegisteredNotificationAch:
                    return "Notificación Ach no registrada.";
                case ErrorMessages.NotUpdatedNotificationAch:
                    return "Notificación Ach no actualizada.";
                case ErrorMessages.UnidentifiedNotificationAch:
                    return "Notificación Ach no identificada.";
                case ErrorMessages.NotRegisteredNotificationEmail:
                    return "Notificación Email no registrada.";
                case ErrorMessages.NotUpdatedNotificationEmail:
                    return "Notificación Email no actualizada.";
                case ErrorMessages.UnidentifiedNotificationEmail:
                    return "Notificación Email no identificada.";
                case ErrorMessages.NotRegisteredNotificationUrl:
                    return "Notificación Url no registrada.";
                case ErrorMessages.NotUpdatedNotificationUrl:
                    return "Notificación Url no actualizada.";
                case ErrorMessages.UnidentifiedNotificationUrl:
                    return "Notificación Url no identificada.";
                case ErrorMessages.NotRegisteredNotificationService:
                    return "Servicio Notificación no registrada.";
                case ErrorMessages.NotUpdatedNotificationService:
                    return "Servicio Notificación no actualizada.";
                case ErrorMessages.UnidentifiedNotificationService:
                    return "Servicio Notificación no identificada.";
                case ErrorMessages.UnidentifiedBusiness:
                    return "Empresa no identificada.";
                case ErrorMessages.WalletServiceError:
                    return "Ha ocurrido un error en el Soli, por favor verifique los datos.";
                case ErrorMessages.ExpireDateInvalid:
                    return "Fecha de expiración de la tarjeta no válido.";
                case ErrorMessages.ComplementIdcInvalid:
                    return "Complemento o CI no válido, por favor verifique los datos.";
                default:
                    return "Ha ocurrido un error.";
            }
        }
    }
}
