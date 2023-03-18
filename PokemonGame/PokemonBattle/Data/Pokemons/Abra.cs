using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Abra : Pokemon
	{
		public override string Name => "Abra";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicguard() };
		public override Stats BaseStats => new Stats(25, 20, 15, 105, 55, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Teleport() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Foulplay(), new Grassknot(), new Guardswap(), new Hiddenpower(), new Icepunch(), new Irontail(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Speedswap(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunderpunch(), new Thunderwave(), new Torment(), new Triattack(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Allyswitch(), new Confusion(), new Encore(), new Firepunch(), new Guardsplit(), new Guardswap(), new Icepunch(), new Knockoff(), new Magiccoat(), new Powertrick(), new Psychoshift(), new Thunderpunch() };
		public override int Weight => 195;
		public override int ExpYield => 62;
		public override int CatchRate => 200;
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