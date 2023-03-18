using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chingling : Pokemon
	{
		public override string Name => "Chingling";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(45, 30, 50, 65, 50, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wrap() },
			[4] = new List<Move>() { new Moves.Growl() },
			[7] = new List<Move>() { new Moves.Astonish() },
			[10] = new List<Move>() { new Moves.Confusion() },
			[13] = new List<Move>() { new Moves.Yawn() },
			[16] = new List<Move>() { new Moves.Lastresort() },
			[19] = new List<Move>() { new Moves.Entrainment() },
			[32] = new List<Move>() { new Moves.Uproar() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bind(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Cosmicpower(), new Moves.Curse(), new Moves.Disable(), new Moves.Futuresight(), new Moves.Hypnosis(), new Moves.Recover(), new Moves.Storedpower(), new Moves.Wish() };
		public override int Weight => 6;
		public override int ExpYield => 57;
		public override int CatchRate => 120;
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