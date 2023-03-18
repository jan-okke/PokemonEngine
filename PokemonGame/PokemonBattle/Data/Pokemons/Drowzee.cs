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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
		public override Stats BaseStats => new Stats(60, 48, 45, 43, 90, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Hypnosis() },
			[5] = new List<Move>() { new Moves.Disable() },
			[9] = new List<Move>() { new Moves.Confusion() },
			[13] = new List<Move>() { new Moves.Headbutt() },
			[17] = new List<Move>() { new Moves.Poisongas() },
			[21] = new List<Move>() { new Moves.Hypnosis() },
			[25] = new List<Move>() { new Moves.Psybeam() },
			[29] = new List<Move>() { new Moves.Mindreader() },
			[33] = new List<Move>() { new Moves.Psychup() },
			[37] = new List<Move>() { new Moves.Hypnosis() },
			[41] = new List<Move>() { new Moves.Zenheadbutt() },
			[45] = new List<Move>() { new Moves.Swagger() },
			[49] = new List<Move>() { new Moves.Psychic() },
			[53] = new List<Move>() { new Moves.Nastyplot() },
			[57] = new List<Move>() { new Moves.Psyshock() },
			[61] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Nastyplot(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Firepunch(), new Moves.Flatter(), new Moves.Guardswap(), new Moves.Icepunch(), new Moves.Powersplit(), new Moves.Psychocut(), new Moves.Roleplay(), new Moves.Thunderpunch() };
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