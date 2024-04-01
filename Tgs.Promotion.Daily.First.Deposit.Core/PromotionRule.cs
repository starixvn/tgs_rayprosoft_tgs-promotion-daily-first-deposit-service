using System.Text.Json.Serialization;

namespace Tgs.Promotion.Daily.First.Deposit.Core;
public record PromotionRule(
	[property: JsonPropertyName("compaignDetail")] DepositRewardSetting CampaignDetail);
