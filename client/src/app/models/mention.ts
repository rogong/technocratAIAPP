export interface Mention {
    id: number;
    sourceRowId: number | null;
    rawSource: string;
    sourceUserId: string;
    mentionEnglish: string;
    rawMention: string;
    mentionDefaultLang: string;
    sentiment: number;
    keyTerms: string;
    // recommendation: string;
    quantity: number;
    growth: number;
    topicLevel1Id: number | null;
    // topicLevel2Id: number | null;
    // topicLevel3Id: number | null;
    dataSourceId: number | null;
    productId: number | null;
    languageId: number | null;
    regionId: number | null;
    marketId: number | null;
    createdOn: string;
    updatedOn: string | null;
    dateKey: number;
}