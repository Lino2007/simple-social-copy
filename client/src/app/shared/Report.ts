import { ApiEntity } from "./BaseEntity";

export interface Report extends ApiEntity {
    reason: string;
    resolved?: boolean;
    postId?: string;
    commentId?: string;
}