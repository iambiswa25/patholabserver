using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.BuisnessLogic.DTOs;
using Patholabs_Express.DataAccess;
using Patholabs_Express.DataAccess.Entities;
using Patholabs_Express.DataAccess.Repository;

namespace Patholabs_Express.BuisnessLogic.Services
{
   
        public class Test_DetailsService : IDisposable
        {
            private readonly Test_DetailsRepository testRepository;



            private readonly Patholabs_ExpressModel context;
            public Test_DetailsService()
            {
                context = new Patholabs_ExpressModel();
                testRepository = new Test_DetailsRepository();
            }


            public void Dispose()
            {
                context.Dispose();
            }


            public List<Test_Details> getall()
            {
                try
                {
                    return testRepository.Get();
                }

                catch (System.Data.Common.DbException ex)
                {
                    throw new Patholabs_ExpressException("Error reading data", ex);
                }

                catch (Exception ex)
                {
                    throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
                }
            }


            public bool Add(Test_DetailsDto dto)
            {
                try
                {
                    if (!testRepository.Exists(dto.TestId))
                    {

                        var test = new Test_Details { TestId = dto.TestId, TestName = dto.TestName, TestPrice = dto.TestPrice };
                        return testRepository.Add(test) == 1;
                    }
                    else
                    {
                        return false;
                    }
                }

                catch (System.Data.Common.DbException ex)
                {
                    throw new Patholabs_ExpressException("Error reading data", ex);
                }

                catch (Exception ex)
                {
                    throw new Patholabs_ExpressException("Unknown error while reading User Admin data", ex);
                }
            }
            public bool UpdateTest(Test_DetailsDto dto)
            {
                var Item = testRepository.TestItem(dto.TestId);
                Item.TestPrice = dto.TestPrice;
                return testRepository.Update(Item) == 1;
            }
        }

    }

