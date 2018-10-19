# Dot.NetCore.Identity.MongoDb

forked from matteofabbri/AspNetCore.Identity.Mongo and bwets/bwets.NetCore.Identity.MongoDb

The main difference from bwets' repo is that this relies upon a Guid IdentityObject identifier that is reflected as a String type rather than a Guid type. In MongoDB this allows the use of a string _id field rather than MongoDB's representation of a Guid.

# Usage

    services.AddMongoIdentityProvider<ApplicationUser, ApplicationRole>(options =>
    {
            options.Password.RequiredLength = 6;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            
    }, dbOptions => {
		dbOptions.ConnectionString = "mongodb://localhost/yourDatabase";
		dbOptions.UsersCollection = "Users"; // this is the default value;
		dbOptions.RolesCollection = "Roles"; // this is the default value;
	});
    
