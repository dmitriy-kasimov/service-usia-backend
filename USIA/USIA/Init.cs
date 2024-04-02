using AltV.Net;
using USIA.Domain.Core;
using USIA.Infrastructure.Business;
using USIA.Infrastructure.Business.Exceptions;
using USIA.Infrastructure.Data.Exceptions;

namespace USIA
{
    internal class Init : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void UserConnect(User user, string reason)
        {
            Console.WriteLine("Игрок подключился");
            user.Emit("Freeze");
            user.Emit("Unfreeze");

            ServiceUSIA serviceUSIA = new ServiceUSIA();


            try
            {
                serviceUSIA.Register("Dima_Kasim", "kasim345", "kasim345", true);
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }


            //Console.WriteLine("[TEST START]: testing microservice Register");
            //try
            //{
            //    serviceUSIA.Register("", "kasim345", "kasim345", true);
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Register("Dima_Kasim", "kasim345", "asdf12", true);
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Register("Dima_Kasim", "ka", "ka", true);
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Register("Dima_Kasim", "kasim345", "kasim345", false);
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Register("Dima_Kasim", "kasim345", "kasim345", true);
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //Console.WriteLine("[TEST FINISH]: testing microservice Register");
            //Console.WriteLine("[TEST START]: testing microservice Login");

            //try
            //{
            //    serviceUSIA.Login("", "_HexaSix2021XYZ");
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Login("TR271V0R", "");
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Login("Blaga_28rus", "123321777");
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Login("TR271V0R", "#_!_WRONG_PASSWORD");
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //try
            //{
            //    serviceUSIA.Login("TR271V0R", "_HexaSix2021XYZ");
            //    Console.WriteLine("The user TR271V0R was successfully identificated!");
            //}
            //catch (ValidateException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (ServerException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}

            //Console.WriteLine("[TEST FINISH]: testing microservice Login");
        }
    }
}


/*

            try
            {
                serviceUSIA.Login("", "_HexaSix2021XYZ");
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                serviceUSIA.Login("TR271V0R", "");
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                serviceUSIA.Login("Blaga_28rus", "123321");
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                serviceUSIA.Login("TR271V0R", "#_!_WRONG_PASSWORD");
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                serviceUSIA.Login("TR271V0R", "_HexaSix2021XYZ123");
                Console.WriteLine("The user TR271V0R was successfully identificated!");
            }
            catch (ValidateException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ServerException ex)
            {
                Console.WriteLine($"{ex.Message}");
            } 

 */