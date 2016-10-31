using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

namespace SampleRESTClient.src.main.CsharpDotNet2.IO.Swagger.Managers
{
    /**
     * This is the main class that contains the sample API calls and their outputs.
     * The sample is driven via the main method with most of API calls separated into their own
     * methods for better readability.
     */
    class ApplicationManager
    {
        // This class contains the backend functionality for sending the API request and receiving the response
        ApiClient zApi;

        // This class contains the API calls relating to the Account object
        AccountsApi accountsApi;

        // This class contains the API calls relating to the Subscription object
        SubscriptionsApi subscriptionsApi;

        // This class contains the API calls relating to the Catalog object
        CatalogApi catalogApi;

        /**
         * Constructor to take in API credentials and create the backend API client
         * Also initializes the specific API clients for each object that will be used
         * 
         * user: The Zuora API username
         * pass: The Zuora API password
         */
        public ApplicationManager(String user, String pass)
        {
            //Creating the API client with the new REST endpoint
            zApi = new ApiClient("https://rest.apisandbox.zuora.com/v1");

            //Adding the username and password to the header for subsequent API calls
            zApi.AddDefaultHeader("apiAccessKeyId", user);
            zApi.AddDefaultHeader("apiSecretAccessKey", pass);

            //Initializing API clients for Product Catalog, Accounts, and Subscriptions
            catalogApi = new CatalogApi(zApi);
            accountsApi = new AccountsApi(zApi);
            subscriptionsApi = new SubscriptionsApi(zApi);
        }

        /**
         * Method for creating a Zuora Account and Subscription with the given product
         * 
         * prodId: The ID of the product to be added to the new subscription
         */
        public POSTAccountResponseType createAccountAndSub(String prodId)
        {
            //Initialize the Account container
            POSTAccountType zAcc = new POSTAccountType();

            //Initialize the Bill-To Contact container
            POSTAccountTypeBillToContact bill2Contact = new POSTAccountTypeBillToContact();
            //Populate the Bill-To Contact with all required fields
            bill2Contact.FirstName = "John";
            bill2Contact.LastName = "Doe";
            bill2Contact.Country = "USA";
            bill2Contact.State = "Georgia";

            //Initialize the Sold-To Contact container
            POSTAccountTypeSoldToContact sold2Contact = new POSTAccountTypeSoldToContact();
            //Populate the Sold-To Contact with all required fields
            sold2Contact.FirstName = "John";
            sold2Contact.LastName = "Doe";
            sold2Contact.Country = "USA";
            sold2Contact.State = "Georgia";

            //Initialize the Credit Card container
            POSTAccountTypeCreditCard creditCard = new POSTAccountTypeCreditCard();

            //Initialize the Card-Holder Information container
            POSTAccountTypeCreditCardCardHolderInfo info = new POSTAccountTypeCreditCardCardHolderInfo();

            //Populate the Card-Holder Information with all required fields
            info.CardHolderName = "John Doe";
            info.AddressLine1 = "3525 Piedmont Road";
            info.City = "Atlanta";
            info.City = "USA";
            info.State = "GA";
            info.ZipCode = "30305";

            //Set the Card-Holder Information on the Credit Card container
            creditCard.CardHolderInfo = info;

            //Populate the Credit Card with all required fields
            creditCard.CardType = "Visa";
            creditCard.CardNumber = "4111111111111111";
            creditCard.ExpirationMonth = "10";
            creditCard.ExpirationYear = "2020";
            creditCard.SecurityCode = "111";

            //Initialize the Subscription container
            POSTAccountTypeSubscription subscription = new POSTAccountTypeSubscription();

            //Initialize the Rate Plan container list (Must use a list as the subscription can have multiple rate plans)
            List<POSTSrpCreateType> ratePlanList = new List<POSTSrpCreateType>();

            //Initialize the individual Rate Plan container
            POSTSrpCreateType ratePlan = new POSTSrpCreateType();
            
            //Populate the Rate Plan container with the required field
            ratePlan.ProductRatePlanId = prodId;

            //Add the individual Rate Plan container to the list
            ratePlanList.Add(ratePlan);

            //Add the list of Rate Plans to the Subscription container
            subscription.SubscribeToRatePlans = ratePlanList;

            //Populate the subscription with all other required fields
            subscription.TermType = "TERMED";
            subscription.AutoRenew = false;
            subscription.InitialTerm = 12;
            subscription.RenewalTerm = 12;
            subscription.ContractEffectiveDate = new DateTime(2016, 10, 17);

            //Add the Bill-To Contact container to the Account
            zAcc.BillToContact = bill2Contact;

            //Add the Sold-To Contact container to the Account
            zAcc.SoldToContact = sold2Contact;

            //Add the Credit Card container to the Account
            zAcc.CreditCard = creditCard;

            //Add the Subscription container to the Account
            zAcc.Subscription = subscription;

            //Populate all other required fields on the Account
            zAcc.Name = "Test Account";
            zAcc.Currency = "USD";

            //Submit the API call by passing in the required Account container and the API version
            return accountsApi.POSTAccount(zAcc, "196.0");
        }

        /**
         * Method for upgading a subscription
         * This method takes a given subscription and removes the rate plan specified for removal and adds the product 
         * rate plan specified for addition
         * 
         * subNum: The Subscription Number of the subscription to be changed
         * removeRpId: The ID of the Rate Plan to be removed from the subscription
         * addPrpId: The ID of the Product Rate Plan to be added to the subscription
         */
        public PUTSubscriptionResponseType upgradeSubscription(String subNum, String removeRpId, String addPrpId)
        {
            //Initialize the container for the new version of the subscription
            PUTSubscriptionType updatedSub = new PUTSubscriptionType();

            //Initialize the list of product rate plans to be added to the subscription
            List<PUTSrpAddType> ratePlanList = new List<PUTSrpAddType>();

            //Initalize the container for the added Subscription Rate Plan
            PUTSrpAddType ratePlan = new PUTSrpAddType();

            //Populate all required fields on the Subscription Rate Plan
            ratePlan.ProductRatePlanId = addPrpId;
            ratePlan.ContractEffectiveDate = new DateTime(2016, 10, 25);

            //Add the Subscription Rate Plan container to the list
            ratePlanList.Add(ratePlan);

            //Set the list of Subscription Rate Plans to be added on the subscription
            updatedSub.Add = ratePlanList;

            //Initialize the list of subscription rate plans to be removed from the subscription
            List<PUTSrpRemoveType> removeRatePlanList = new List<PUTSrpRemoveType>();

            //Initialize the container for the Subscription Rate Plan to be removed
            PUTSrpRemoveType removeRatePlan = new PUTSrpRemoveType();

            //Populate all required fields on the Subscription Rate Plan
            removeRatePlan.RatePlanId = removeRpId;
            removeRatePlan.ContractEffectiveDate = new DateTime(2016, 10, 25);

            //Add the Subscription Rate Plan to the list
            removeRatePlanList.Add(removeRatePlan);

            //Set the list of Subscription Rate Plans to be removed from the subscription
            updatedSub.Remove = removeRatePlanList;

            //Submit the API call by passing in the required Subscription Key(Subscription Number), Subscription container, and API version
            return subscriptionsApi.PUTSubscription(subNum, updatedSub, "196.0");
        }

        /**
         * Method for cancelling a subscription
         * 
         * subNum: The number of the subscription to be cancelled
         */
        public POSTSubscriptionCancellationResponseType cancelSubscription(String subNum)
        {
            //Initialize the Cancel Subscription request container
            POSTSubscriptionCancellationType cancelSub = new POSTSubscriptionCancellationType();

            //Populate the container with all required fields
            cancelSub.CancellationPolicy = "SpecificDate";
            cancelSub.Invoice = false;
            cancelSub.CancellationEffectiveDate = new DateTime(2016, 11, 3);

            //Submit the API call by passing in the required Subscription Key(Subscription Number), Cancel Request container, and API version
            return subscriptionsApi.POSTSubscriptionCancellation(subNum, cancelSub, "196.0");
        }

        /**
         * Main method for executing the sample API calls in sequence
         */
        static void Main(string[] args)
        {
            //Must set the JSON serializer settings so that null values are not passed to the API
            //Passing null values will result in a failed API call
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            //Initialize the Application Manager which contains all methods and objects used for the QuickStart
            //TODO UPDATE WITH YOUR USERNAME AND PASSWORD FOR YOUR ZUORA TEST DRIVE TENANT
            ApplicationManager manager = new ApplicationManager("user@zuoratestdrive.com", "ZuoraTestDrivePassword");

            //Name of the initial product rate plan to be added in our new subscription
            String productRatePlan1Name = "Quarterly Plan";
            //Name of the "upgraded" product rate plan to be added to the upgraded subscription
            String productRatePlan2Name = "Annual Plan";

            //Creating ojects to store the IDs of the above product rate plans
            String productRatePlan1Id = null;
            String productRatePlan2Id = null;

            Console.Out.WriteLine("Calling Get Catalog >");
            //Use the GET Catalog call to retrieve the entire product catalog and store it in the catalog container
            GETCatalogType catalog = manager.catalogApi.GETCatalog();

            //Get the list of products from the catalog container
            List<GETProductType> products = catalog.Products;

            //Loop through all products to find the ones we will use
            foreach(GETProductType p in products)
            {
                //Get the list of rate plans from the product container
                List<GETProductRatePlanType> ratePlans = p.ProductRatePlans;

                //Loop through all rate plans for this product
                foreach(GETProductRatePlanType rp in ratePlans)
                {
                    //If the initial product rate plan is identified...
                    if (productRatePlan1Name.Equals(rp.Name))
                    {
                        Console.Out.WriteLine("Product Rate Plan 1 found: " + rp.ToString());

                        //Store the ID for our initial product rate plan
                        productRatePlan1Id = rp.Id;
                    }

                    //If the upgraded product rate plan is identified...
                    if (productRatePlan2Name.Equals(rp.Name))
                    {
                        Console.Out.WriteLine("Product Rate Plan 2 found: " + rp.ToString());

                        //Store the ID for our upgraded product rate plan
                        productRatePlan2Id = rp.Id;
                    }
                }
            }

            //Create an object to store the result of the Create Account call
            POSTAccountResponseType accResponse = null;

            //If the initial product rate plan was found...
            if (productRatePlan1Id != null)
            {
                Console.Out.WriteLine("Calling Create Account and Subscription >");

                //Create an account and subscription using the initial product rate plan
                accResponse = manager.createAccountAndSub(productRatePlan1Id);
                Console.Out.WriteLine("POSTAccountResponseType: " + accResponse.ToString());
            }
            else
            {
                Console.Out.WriteLine("Product Rate Plan 1, 'Quarterly Plan', was not found");
            }

            //If the upgraded product rate plan was found...
            if (productRatePlan2Id != null)
            {
                //If the create account call was successful...
                if ((accResponse != null) && (accResponse.Success == true))
                {
                    //Create an object to store the subscription rate plan
                    String existingRpId = null;

                    //Query for the subscription that was created to get the existing subscription rate plan using the GET One Subscription call
                    //This call takes in the Subscription key(Subscriptin Number) and the Charge Detail segments to be returned
                    GETSubscriptionTypeWithSuccess getSubResponse = manager.subscriptionsApi.GETOneSubscription(accResponse.SubscriptionNumber, "all-segments");

                    //Get the list of subscription rate plans from the Subscription response container
                    List<GETSubscriptionRatePlanType> ratePlans = getSubResponse.RatePlans;

                    //Loop through each rate plan in the existing subscription
                    foreach(GETSubscriptionRatePlanType rp in ratePlans)
                    {
                        //If the name of the subscription rate plan matches that of our initial product rate plan...
                        if(productRatePlan1Name.Equals(rp.RatePlanName))
                        {
                            Console.Out.WriteLine("Previous Rate Plan found: " + rp.ToString());

                            //Store the ID of the existing subscription rate plan
                            existingRpId = rp.Id;
                        }
                    }

                    Console.Out.WriteLine("Calling Subscription Upgrade >");

                    //Upgrade the subscription by passing the Subscription Number, exisitng Subscription Rate Plan, and new Product Rate Plan into our custom method
                    PUTSubscriptionResponseType subUpgradeResponse = manager.upgradeSubscription(accResponse.SubscriptionNumber, existingRpId , productRatePlan2Id);
                    Console.Out.WriteLine("PUTSubscriptionResponseType: " + subUpgradeResponse.ToString());

                    //If there are failure reasons on the subscription upgrade response...
                    if(subUpgradeResponse.Reasons != null) {
                        //Loop through each failure reason and print it to console for review
                        foreach(ErrorCodeType reason in subUpgradeResponse.Reasons)
                        {
                            Console.Out.WriteLine(reason.ToString());
                        }
                    }
                }
                else
                {
                    Console.Out.WriteLine("Account and Subscription creation failed");
                }
            }
            else
            {
                Console.Out.WriteLine("Product 2, 'Annual Plan', was not found");
            }

            //If our account and subscription were created successfully...
            if ((accResponse != null) && (accResponse.Success == true))
            {
                Console.Out.WriteLine("Calling Subscription Cancel >");

                //Cancel the subscription we created
                POSTSubscriptionCancellationResponseType cancelResponse = manager.cancelSubscription(accResponse.SubscriptionNumber);
                Console.Out.WriteLine("POSTSubscriptionCancellationResponsType: " + cancelResponse.ToString());
            }
            else
            {
                Console.Out.WriteAsync("Account and subscription were not created and cannot be canceled");
            }

            //Console will await any user input before exiting allowing the user to review the results in the output
            Console.ReadLine();
        }
    }
}
