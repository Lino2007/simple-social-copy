import { BaseEntity } from "./BaseEntity";

export interface Comment extends BaseEntity {
    content: string;
    authorId?: string;
    postId?: string;
    editable?: boolean;
}