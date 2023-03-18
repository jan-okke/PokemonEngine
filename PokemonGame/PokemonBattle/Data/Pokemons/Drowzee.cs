using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drowzee : Pokemon
	{
		public override string Name => "Drowzee";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(60, 48, 45, 43, 90, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Hypnosis() },
			[5] = new List<Move>() { new Disable() },
			[9] = new List<Move>() { new Confusion() },
			[13] = new List<Move>() { new Headbutt() },
			[17] = new List<Move>() { new Poisongas() },
			[21] = new List<Move>() { new Hypnosis() },
			[25] = new List<Move>() { new Psybeam() },
			[29] = new List<Move>() { new Mindreader() },
			[33] = new List<Move>() { new Psychup() },
			[37] = new List<Move>() { new Hypnosis() },
			[41] = new List<Move>() { new Zenheadbutt() },
			[45] = new List<Move>() { new Swagger() },
			[49] = new List<Move>() { new Psychic() },
			[53] = new List<Move>() { new Nastyplot() },
			[57] = new List<Move>() { new Psyshock() },
			[61] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Brickbreak(), new Calmmind(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Foulplay(), new Frustration(), new Grassknot(), new Hiddenpower(), new Icepunch(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magiccoat(), new Magicroom(), new Nastyplot(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Firepunch(), new Flatter(), new Guardswap(), new Icepunch(), new Powersplit(), new Psychocut(), new Roleplay(), new Thunderpunch() };
		public override int Weight => 324;
		public override int ExpYield => 66;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}