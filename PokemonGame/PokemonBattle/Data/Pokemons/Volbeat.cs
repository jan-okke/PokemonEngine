using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Volbeat : Pokemon
	{
		public override string Name => "Volbeat";
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(65, 73, 75, 85, 47, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Playnice(), new Tackle() },
			[5] = new List<Move>() { new Doubleteam() },
			[8] = new List<Move>() { new Confuseray() },
			[12] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Strugglebug() },
			[19] = new List<Move>() { new Moonlight() },
			[22] = new List<Move>() { new Tailglow() },
			[26] = new List<Move>() { new Encore() },
			[29] = new List<Move>() { new Protect() },
			[33] = new List<Move>() { new Zenheadbutt() },
			[36] = new List<Move>() { new Helpinghand() },
			[40] = new List<Move>() { new Bugbuzz() },
			[43] = new List<Move>() { new Playrough() },
			[47] = new List<Move>() { new Doubleedge() },
			[50] = new List<Move>() { new Infestation() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bugbite(), new Bugbuzz(), new Chargebeam(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Frustration(), new Gigadrain(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Infestation(), new Lightscreen(), new Poweruppunch(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Shadowball(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trick(), new Uturn(), new Waterpulse(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Encore(), new Lunge(), new Seismictoss(), new Trick() };
		public override int Weight => 177;
		public override int ExpYield => 151;
		public override int CatchRate => 150;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}