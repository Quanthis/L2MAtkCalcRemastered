using System;
using System.Threading.Tasks;

namespace L2MAtkCalcRemastered
{
    public interface SendableAsync
    {
        Task<string> ConvertToSendableForm();
    }
}
