# BusinessLayer

The platform contains common components that will allow faster aplications development. The platform assumes simplicity and code base.

BusinessLayer.Core contains common components:
- extensions
- helpers

BusinessLayer.Model contains:
- repository models and interfaces
- database models and interfaces 
- service models and interfaces 
- business models and interfaces to extend

BusinessLayer.Model classes allow 
- advanced support for business operations results 
- easy error handling
- easy warning handling
- simple transfer of objects and messages

Road map:
- Configuration
- Logging
- Testing
- Exception Handling
- Guard

Examples:
<pre><code class='language-cs'>
  public ServiceOperationResult<ProductViewModel> Create(ProductViewModel model)
      {
          try
          {
              using (IUnitOfWork uow = new UnitOfWork(_componentContext))
              {
                  var repository = uow.GetRepository<IProductRepository>();
                  repository.Create(model.ConvertToDomainModel());

                  uow.Commit();

                  return ServiceOperationResult<ProductViewModel>.Ok(model);
              }
          }
          catch (Exception ex)
          {
              return ServiceOperationResult<ProductViewModel>.Error(ex, model, "Operation completed with an error");
          }
      }
</code></pre>


<pre><code class='language-cs'>
public RepositoryOperationResult<Product> Create(Product item)
    {
        try
        {
            _dataContext.Products.Add(item);
            _dataContext.SaveChanges();

            return RepositoryOperationResult<Product>.Ok(item);
        }
        catch (Exception ex)
        {
            return RepositoryOperationResult<Product>.Error(ex, item, "Operation completed with an error");
        }
    }
 </code></pre>
