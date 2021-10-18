
namespace AppSettings
{
    class AzureKeys {         
        static void Main(string[] args)
        {
            string azureaccesskey = "3wyR9lQCb+3vkTj60CBcd5KZ6Q4YUW8HgPcYG06iakXdGQtSpCchO4daRXTb9xJFRbBKfX1auIoYM0yhmhO1+Q==";
            string azuresastoken = "?sv=2020-08-04&ss=bfqt&srt=c&sp=rwdlacuptfx&se=2021-10-20T15:58:12Z&st=2021-10-18T07:58:12Z&spr=https&sig=idjxKyHrD9C6jBpemhyNlddWvLV5VVtaUpoIgJatCXU%3D"
            string sasconnectionstring = "BlobEndpoint=https://secteststg.blob.core.windows.net/;QueueEndpoint=https://secteststg.queue.core.windows.net/;FileEndpoint=https://secteststg.file.core.windows.net/;TableEndpoint=https://secteststg.table.core.windows.net/;SharedAccessSignature=sv=2020-08-04&ss=bfqt&srt=c&sp=rwdlacuptfx&se=2021-10-20T15:58:12Z&st=2021-10-18T07:58:12Z&spr=https&sig=idjxKyHrD9C6jBpemhyNlddWvLV5VVtaUpoIgJatCXU%3D"

            System.Console.WriteLine("Azure keys are as follows");
        }
    }
}

