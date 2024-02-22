import { Column, Entity, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class NoteType {
  @PrimaryGeneratedColumn()
  Id: number;

  @Column({ length: 50, nullable: false })
  Name: string;
}