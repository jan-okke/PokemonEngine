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
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(45, 30, 50, 65, 50, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap() },
			[4] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Astonish() },
			[10] = new List<Move>() { new Confusion() },
			[13] = new List<Move>() { new Yawn() },
			[16] = new List<Move>() { new Lastresort() },
			[19] = new List<Move>() { new Entrainment() },
			[32] = new List<Move>() { new Uproar() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bind(), new Calmmind(), new Chargebeam(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Facade(), new Flash(), new Frustration(), new Grassknot(), new Gravity(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Knockoff(), new Lastresort(), new Lightscreen(), new Magiccoat(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Uproar(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Cosmicpower(), new Curse(), new Disable(), new Futuresight(), new Hypnosis(), new Recover(), new Storedpower(), new Wish() };
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