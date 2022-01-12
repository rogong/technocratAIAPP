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
  brand: string;
  competition: string;
  dataSource: string;
  productId: number | null;
  languageId: number | null;
  region: string;
  marketId: number | null;
  createdOn: string;
  updatedOn: string | null;
  dateKey: number;
}

export interface MentionParams {
  orderBy: string;
  searchTerm?: string;
  datasources: string[];
  markets: string[];
  regions: string[];
  products: string[];
  languages: string[];
  brands: string[];
  competitions: string[];
  pageNumber: number;
  pageSize: number;
}
