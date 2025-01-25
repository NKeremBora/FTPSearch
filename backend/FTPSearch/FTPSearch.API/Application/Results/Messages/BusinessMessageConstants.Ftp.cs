using FTPSearch.API.Application.Results.Messages.Common;

namespace FTPSearch.API.Application.Results.Messages;

public static partial class BusinessMessageConstants
{
    public partial struct Success
    {
        public partial struct Ftp
        {
            // 2xx Status Codes

            #region Status Code - 200

            public static readonly BusinessMessage AllFound = new(
                Message: "FTP üzerindeki tüm dosyaların getirilmesi işlemi başarılı!",
                Code: "FTP20001",
                HttpStatus: StatusCodes.Status200OK
            );

            #endregion
        }
    }

    public partial struct Error
    {
        public partial struct Ftp
        {
            // 4xx Status Codes
            
            #region Status Code - 404
            
            public static readonly BusinessMessage NotFound = new(
                Message: "FTP üzerinde herhangi bir dosya bulunamadı.",
                Code: "FTP40401",
                HttpStatus: StatusCodes.Status404NotFound
            );
            
            #endregion
        }
    }
}