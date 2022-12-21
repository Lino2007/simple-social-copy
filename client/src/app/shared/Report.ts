import { BaseEntity } from "./BaseEntity";

export interface Report extends BaseEntity {
    reason: string;
    resolved?: boolean;
    postId?: string;
    commentId?: string;
}