using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class VaultsService
  {
    private readonly VaultsRepository _repo;
    public VaultsService(VaultsRepository repo)
    {
      _repo = repo;
    }


    public IEnumerable<Vault> Get(string userId)
    {
      return _repo.Get(userId);
    }



    public Vault Get(int id)
    {
      Vault found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }



    public Vault Create(Vault newVault)
    {
      Vault created = _repo.Create(newVault);
      if (created == null)
      {
        throw new Exception("create failed");
      }
      return created;
    }



    public Vault Delete(int id, string userId)
    {
      Vault found = Get(id);
      if (found.UserId != userId)
      {
        throw new Exception("Invalid Request");
      }
      if (_repo.Delete(id))
      {
        return found;
      }
      throw new Exception("Something went terribly wrong");
    }


  }
}