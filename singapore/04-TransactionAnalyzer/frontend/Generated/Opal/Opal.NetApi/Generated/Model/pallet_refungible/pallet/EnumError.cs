//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Opal.NetApi.Generated.Model.pallet_refungible.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotRefungibleDataUsedToMintFungibleCollectionToken
        /// Not Refungible item data used to mint in Refungible collection.
        /// </summary>
        NotRefungibleDataUsedToMintFungibleCollectionToken = 0,
        
        /// <summary>
        /// >> WrongRefungiblePieces
        /// Maximum refungibility exceeded.
        /// </summary>
        WrongRefungiblePieces = 1,
        
        /// <summary>
        /// >> RepartitionWhileNotOwningAllPieces
        /// Refungible token can't be repartitioned by user who isn't owns all pieces.
        /// </summary>
        RepartitionWhileNotOwningAllPieces = 2,
        
        /// <summary>
        /// >> RefungibleDisallowsNesting
        /// Refungible token can't nest other tokens.
        /// </summary>
        RefungibleDisallowsNesting = 3,
        
        /// <summary>
        /// >> SettingPropertiesNotAllowed
        /// Setting item properties is not allowed.
        /// </summary>
        SettingPropertiesNotAllowed = 4,
    }
    
    /// <summary>
    /// >> 625 - Variant[pallet_refungible.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}