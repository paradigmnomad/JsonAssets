﻿using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonAssets.Data
{
    public class FruitTreeData : DataNeedsIdWithTexture
    {
        public object Product { get; set; }
        public string SaplingName { get; set; }
        public string SaplingDescription { get; set; }

        public string Season { get; set; }

        public IList<string> SaplingPurchaseRequirements { get; set; } = new List<string>();
        public int SaplingPurchasePrice { get; set; }
        public string SaplingPurchaseFrom { get; set; } = "Pierre";
        public IList<PurchaseData> SaplingAdditionalPurchaseData { get; set; } = new List<PurchaseData>();

        public Dictionary<string, string> SaplingNameLocalization = new Dictionary<string, string>();
        public Dictionary<string, string> SaplingDescriptionLocalization = new Dictionary<string, string>();

        internal ObjectData sapling;
        public int GetSaplingId() { return sapling.id; }
        public int GetFruitTreeIndex() { return id; }
        internal string GetFruitTreeInformation()
        {
            return $"{GetFruitTreeIndex()}/{Season}/{Mod.instance.ResolveObjectId(Product)}/what goes here?";
        }
    }
}
