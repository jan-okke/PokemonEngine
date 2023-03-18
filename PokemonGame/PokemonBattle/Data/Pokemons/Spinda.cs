using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spinda : Pokemon
	{
		public override string Name => "Spinda";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Tangledfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
		public override Stats BaseStats => new Stats(60, 60, 60, 60, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle() },
			[5] = new List<Move>() { new Moves.Copycat() },
			[10] = new List<Move>() { new Moves.Teeterdance() },
			[14] = new List<Move>() { new Moves.Psybeam() },
			[19] = new List<Move>() { new Moves.Hypnosis() },
			[23] = new List<Move>() { new Moves.Bodyslam() },
			[28] = new List<Move>() { new Moves.Suckerpunch() },
			[32] = new List<Move>() { new Moves.Teeterdance() },
			[37] = new List<Move>() { new Moves.Uproar() },
			[41] = new List<Move>() { new Moves.Psychup() },
			[46] = new List<Move>() { new Moves.Doubleedge() },
			[50] = new List<Move>() { new Moves.Flail() },
			[55] = new List<Move>() { new Moves.Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Disable(), new Moves.Encore(), new Moves.Fakeout(), new Moves.Faketears(), new Moves.Guardsplit(), new Moves.Icywind(), new Moves.Psychocut(), new Moves.Psychoshift(), new Moves.Rapidspin(), new Moves.Roleplay(), new Moves.Trick(), new Moves.Wish() };
		public override int Weight => 50;
		public override int ExpYield => 126;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}