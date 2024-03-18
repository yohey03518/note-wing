import {Column, Entity, PrimaryGeneratedColumn} from "typeorm";
import {BaseEntity} from "./BaseEntity";

@Entity("NoteDetail")
export class NoteDetail extends BaseEntity{
    @Column()
    categoryId: number

    @Column({length: 100})
    content: string
}